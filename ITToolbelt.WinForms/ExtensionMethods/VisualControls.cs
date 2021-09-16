using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using ITToolbelt.WinForms.InfoForms;

namespace ITToolbelt.WinForms.ExtensionMethods
{
    public static class VisualControls
    {
        public static void StartStopMarque(this ProgressBar progressBar)
        {
            if (progressBar.Style != ProgressBarStyle.Marquee)
            {
                progressBar.Style = ProgressBarStyle.Marquee;
                progressBar.MarqueeAnimationSpeed = 50;
            }
            else
            {
                progressBar.Style = ProgressBarStyle.Continuous;
                progressBar.MarqueeAnimationSpeed = 0;
            }
        }
        public static void StartStopMarque(this ToolStripProgressBar progressBar)
        {
            if (progressBar.Style != ProgressBarStyle.Marquee)
            {
                progressBar.Style = ProgressBarStyle.Marquee;
                progressBar.MarqueeAnimationSpeed = 50;
            }
            else
            {
                progressBar.Style = ProgressBarStyle.Continuous;
                progressBar.MarqueeAnimationSpeed = 0;
            }
        }

        public static void SaveGridColumnStatus(this DataGridView dataGridView)
        {
            XElement xElement = new XElement("Columns");
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                XElement columnElement = new XElement("Column");
                columnElement.Add(new XAttribute("name", column.DataPropertyName));
                columnElement.Add(new XAttribute("visible", column.Visible));
                columnElement.Add(new XAttribute("order", column.DisplayIndex));
                xElement.Add(columnElement);
            }

            string path = Path.Combine(GlobalVariables.DocPath, $"{dataGridView.Tag}.xml");
            xElement.Save(path);
        }
    }
}