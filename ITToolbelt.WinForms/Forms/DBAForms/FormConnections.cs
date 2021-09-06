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

namespace ITToolbelt.WinForms.Forms.DBAForms
{
    public partial class FormConnections : Form
    {
        public FormConnections()
        {
            InitializeComponent();
        }

        private void FormConnections_Load(object sender, EventArgs e)
        {
            RefreshData(false);
        }

        private void RefreshData(bool getFromServer)
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
                RefreshData(true);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshData(true);
        }
    }
}
