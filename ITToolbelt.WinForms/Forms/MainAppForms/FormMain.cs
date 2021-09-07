using System.Linq;
using System.Windows.Forms;
using ITToolbelt.WinForms.Forms.DBAForms;

namespace ITToolbelt.WinForms.Forms.MainAppForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void connectionsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form form = new FormConnections();
            OpenForm(form);
        }

        private void OpenForm(Form f)
        {
            Form form = f;

            Form existForm = MdiChildren.FirstOrDefault(ff => ff.Name == form.Name);
            if (existForm == null)
            {
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                existForm.BringToFront();
            }
        }

        private void indexToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form form = new FormIndexes();
            OpenForm(form);
        }
    }
}
