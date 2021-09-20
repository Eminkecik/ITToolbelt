using System.Windows.Forms;

namespace ITToolbelt.WinForms
{
    public static class GlobalMethods
    {
        public static DialogResult DeleteConfirm(string name)
        {
            return MessageBox.Show($"{name} silinecek, onaylıyor musunuz? Bu işlem geri alınamaz?", "Uyarı!",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}