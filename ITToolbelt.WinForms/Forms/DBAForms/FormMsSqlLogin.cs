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
using ITToolbelt.WinForms.ExtensionMethods;

namespace ITToolbelt.WinForms.Forms.DBAForms
{
    public partial class FormMsSqlLogin : Form
    {
        public bool SuccessFlag { get; set; }
        public string ConnectionString => sqlConnectionString.ConnectionString;

        private SqlConnectionStringBuilder sqlConnectionString;
        private BackgroundWorker backgroundWorker;
        public FormMsSqlLogin()
        {
            InitializeComponent();
            sqlConnectionString = new SqlConnectionStringBuilder();
            comboBoxAuthType.SelectedIndex = 0;

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
            if (comboBoxAuthType.InvokeRequired)
            {
                comboBoxAuthType.Invoke(new MethodInvoker(delegate
                {
                    sqlConnectionString.IntegratedSecurity = comboBoxAuthType.SelectedIndex == 0;
                }));
            }
            else
            {
                sqlConnectionString.IntegratedSecurity = comboBoxAuthType.SelectedIndex == 0;
            }
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
