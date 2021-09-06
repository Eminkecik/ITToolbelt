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
            ConnectionManager connectionManager = new ConnectionManager(GlobalVariables.ConnectionString);
            connectionManager.GetConnections(true);
        }
    }
}
