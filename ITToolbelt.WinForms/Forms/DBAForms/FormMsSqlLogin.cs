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
        public FormMsSqlLogin()
        {
            InitializeComponent();
            sqlConnectionString = new SqlConnectionStringBuilder();
            comboBoxAuthType.SelectedIndex = 0;
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
            sqlConnectionString.DataSource = textBoxServerName.Text;
            sqlConnectionString.IntegratedSecurity = comboBoxAuthType.SelectedIndex == 0;
            if (sqlConnectionString.IntegratedSecurity)
            {
                sqlConnectionString.UserID = textBoxUserName.Text;
                sqlConnectionString.Password = textBoxPassword.Text;
            }

            progressBarConnection.StartStopMarque();
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

            progressBarConnection.StartStopMarque();

            if (SuccessFlag)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void comboBoxAuthType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            textBoxUserName.Enabled =
                textBoxPassword.Enabled = comboBoxAuthType.SelectedIndex > 0;
        }
    }
}
