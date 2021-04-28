using System;
using System.Windows.Forms;

namespace Bobedre.Utility
{
    public static class ClearForm
    {
        /// <summary>
        /// Clear every textbox in the specific form
        /// </summary>
        /// <param name="Controls"></param>
        public static void CleanForm(Control.ControlCollection Controls) //Taken from https://stackoverflow.com/questions/4811229/how-to-clear-the-text-of-all-textboxes-in-the-form
        {
            foreach (var control in Controls)
            {
                if (control is TextBox box)
                {
                    box.Text = string.Empty;
                }
            }

        }
    }
}
