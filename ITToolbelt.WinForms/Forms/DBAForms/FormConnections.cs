using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.WinForms.ExtensionMethods;
using ITToolbelt.WinForms.Forms.ControlSpesifications;

namespace ITToolbelt.WinForms.Forms.DBAForms
{
    public partial class FormConnections : Form
    {
        private bool getFromServer;
        private BackgroundWorker backgroundWorker;
        public FormConnections()
        {
            InitializeComponent();
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBarConnections.StartStopMarque();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RefreshData();
        }

        private void FormConnections_Load(object sender, EventArgs e)
        {
            getFromServer = false;
            toolStripProgressBarConnections.StartStopMarque();
            backgroundWorker.RunWorkerAsync();
        }

        private void RefreshData()
        {
            ConnectionManager connectionManager = new ConnectionManager(GlobalVariables.ConnectionString);
            List<Connection> connections = connectionManager.GetConnections(getFromServer);
            connectionBindingSource.DataSource = connections;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormMsSqlLogin msSqlLogin = new FormMsSqlLogin();
            msSqlLogin.ShowDialog();

            if (msSqlLogin.SuccessFlag)
            {
                getFromServer = true;
                toolStripProgressBarConnections.StartStopMarque();
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            getFromServer = true;
            toolStripProgressBarConnections.StartStopMarque();
            backgroundWorker.RunWorkerAsync();
        }

        private void dataGridViewConnections_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dataGridViewConnections.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[17];
            if (cell.Value != null && cell.Value.ToString() == "Failed")
            {
                row.DefaultCellStyle.BackColor = Color.Red;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void buttonColumnSelection_Click(object sender, EventArgs e)
        {
            DataGridViewColumnCollection dataGridViewColumnCollection = dataGridViewConnections.Columns;
            FormGridColumnSelection formGridColumnSelection = new FormGridColumnSelection(dataGridViewColumnCollection);
            formGridColumnSelection.ShowDialog();
            dataGridViewConnections.SaveGridColumnStatus();
        }
    }
}
