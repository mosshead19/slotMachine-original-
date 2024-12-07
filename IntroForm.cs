using slotMachine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slotMachine
{
    public partial class IntroForm : Form
    {
        public string UserName { get; private set; }
        public Theme SelectedTheme { get; private set; }
        public IntroForm()
        {
            InitializeComponent();

            cmbThemes.Items.Add("Fruits");
            cmbThemes.Items.Add("Animals");
            cmbThemes.SelectedIndex = 0;
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name to proceed.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Capture the user's name
            UserName = txtName.Text;

            // Set the selected theme
            switch (cmbThemes.SelectedItem.ToString())
            {
                case "Animals":
                    SelectedTheme = new AnimalsTheme();
                    break;
                default:
                    SelectedTheme = new FruitsTheme();
                    break;
            }

            // Close this form and proceed to the main form
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void greetings_Click(object sender, EventArgs e)
        {
            //greetings.Text = $"Hi {UserName} Please Choose your theme";
        }
    }
}
