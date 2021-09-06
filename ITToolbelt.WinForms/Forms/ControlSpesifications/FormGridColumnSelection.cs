using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITToolbelt.WinForms.Forms.ControlSpesifications
{
    public partial class FormGridColumnSelection : Form
    {
        public DataGridViewColumnCollection GridViewColumnCollection { get; set; }

        public FormGridColumnSelection(DataGridViewColumnCollection gridViewColumnCollection)
        {
            GridViewColumnCollection = gridViewColumnCollection;
            InitializeComponent();
        }

        private void FormGridColumnSelection_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn o in GridViewColumnCollection)
            {
                checkedListBoxColumns.Items.Add(o.HeaderText, o.Visible);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in GridViewColumnCollection)
            {
                column.Visible = checkedListBoxColumns.CheckedItems.Contains(column.HeaderText);
            }
            Close();
        }
    }
}
