using System.Windows.Forms;

namespace Aemos.Helpers
{
    public static class WarningMessage
    {
        public static void ShowWarningMessage(string message)
        {
            MessageBox.Show(message,"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
