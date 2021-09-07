using System.Windows.Forms;
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
    }
}