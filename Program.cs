using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slotMachine
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the IntroForm
            using (var introForm = new IntroForm())
            {
                if (introForm.ShowDialog() == DialogResult.OK)
                {
                    // Proceed to Form1 with the user's name and selected theme
                    Application.Run(new Form1(introForm.UserName, introForm.SelectedTheme));
                }
            }
        }
    }
}
