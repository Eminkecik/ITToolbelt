using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.Enum;
using ITToolbelt.WinForms.ExtensionMethods;
using MySql.Data.MySqlClient;

namespace ITToolbelt.WinForms.Forms.DBAForms
{
    public partial class FormMySqlLogin : Form
    {
        public bool SuccessFlag { get; set; }
        public string ConnectionString => sqlConnectionString.ConnectionString;
        public Connection Connection { get; set; }

        private readonly MySqlConnectionStringBuilder sqlConnectionString;
        private readonly BackgroundWorker backgroundWorker;
        private AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        public FormMySqlLogin()
        {
            InitializeComponent();
            sqlConnectionString = new MySqlConnectionStringBuilder();

            Connection = new Connection { DbServerTypeCode = DbServerType.MySql };

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
            sqlConnectionString.Server = textBoxServerName.Text;
            sqlConnectionString.UserID = textBoxUserName.Text;
            sqlConnectionString.Password = textBoxPassword.Text;
            sqlConnectionString.Password = textBoxPassword.Text;

            MySqlConnection sqlConnection = new MySqlConnection(sqlConnectionString.ConnectionString);
            try
            {
                sqlConnection.Open();
                sqlConnection.Close();
                SuccessFlag = true;

                Connection.Name = textBoxConName.Text;
                Connection.ConnectionString = sqlConnectionString.ConnectionString;
                ConnectionManager connectionManager = new ConnectionManager(GlobalVariables.ConnectionString);
                SuccessFlag = connectionManager.Add(Connection);

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

            MessageBox.Show($"Add connection {(SuccessFlag ? "successful" : "failed")}", SuccessFlag ? "Information" : "Error", MessageBoxButtons.OK, SuccessFlag ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (SuccessFlag)
            {
                Close();
            }
        }

        private void buttonHelp_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://dev.mysql.com/doc/connector-net/en/connector-net-connections-string.html");
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
    }
}
