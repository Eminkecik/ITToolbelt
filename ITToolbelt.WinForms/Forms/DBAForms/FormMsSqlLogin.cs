using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.Enum;
using ITToolbelt.WinForms.ExtensionMethods;

namespace ITToolbelt.WinForms.Forms.DBAForms
{
    public partial class FormMsSqlLogin : Form
    {
        public bool SuccessFlag { get; set; }
        public string ConnectionString => sqlConnectionString.ConnectionString;
        public Connection Connection { get; set; }

        private readonly SqlConnectionStringBuilder sqlConnectionString;
        private readonly BackgroundWorker backgroundWorker;
        public FormMsSqlLogin()
        {
            InitializeComponent();
            sqlConnectionString = new SqlConnectionStringBuilder();
            comboBoxAuthType.SelectedIndex = 0;

            Connection = new Connection { DbServerTypeCode = DbServerType.MsSql };

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarConnection.StartStopMarque();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            sqlConnectionString.DataSource = textBoxServerName.Text;
            sqlConnectionString.IntegratedSecurity = comboBoxAuthType.SelectedIndex == 0;
            if (sqlConnectionString.IntegratedSecurity)
            {
                sqlConnectionString.UserID = textBoxUserName.Text;
                sqlConnectionString.Password = textBoxPassword.Text;
            }

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString.ConnectionString);
            try
            {
                sqlConnection.Open();
                SuccessFlag = true;

                Connection.Name = textBoxConName.Text;
                Connection.ConnectionString = sqlConnectionString.ConnectionString;
                ConnectionManager connectionManager = new ConnectionManager(GlobalVariables.ConnectionString);
                connectionManager.Add(Connection);
            }
            catch (Exception exception)
            {
                SuccessFlag = false;
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }

            if (SuccessFlag)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void buttonHelp_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://docs.microsoft.com/en-us/sql/ssms/f1-help/connect-to-server-database-engine");
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            SuccessFlag = false;
            Close();
        }

        private void buttonConnect_Click(object sender, System.EventArgs e)
        {
            progressBarConnection.StartStopMarque();
            backgroundWorker.RunWorkerAsync();
        }

        private void comboBoxAuthType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            textBoxUserName.Enabled =
                textBoxPassword.Enabled = comboBoxAuthType.SelectedIndex > 0;
        }
    }
}
