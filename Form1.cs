using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slotMachine.Models;
using SlotMachine.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace slotMachine
{
    public partial class Form1 : Form
    {
        private Slot slotMachine;
        private readonly string userName;
        private int stake;

        public Form1(string userName, Theme theme)
        {
            InitializeComponent();
            // Initialize PictureBoxes for reels
            // Store the user's name
            this.userName = userName;

            // Initialize SlotMachine with the selected theme
            PictureBox[] pictureBoxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3 };
            slotMachine = new Slot(1000, pictureBoxes, theme);

            // Set up UI
            lblBalance.Text = "Balance: P" + slotMachine.Balance;
            lblUserName.Text = $"Player: {userName}"; // Add a label to show the player's name

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStake.Text, out  stake) && stake > 0 && stake <= slotMachine.Balance)
            {

                slotMachine.Stake = stake;
                slotMachine.UpdateBalance(-stake);
                lblBalance.Text = "Balance: P" + slotMachine.Balance;

                btnSpin.Enabled = false; 	// Disable the button during spin
                lblResult.Text = "";  	// Clear any previous result
                timerSpin.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid stake amount (between 1 and your balance).");
            }

        }


        

       

        private void timerSpin_Tick_1(object sender, EventArgs e)
        {
            slotMachine.Spin();			// Spin the reels

            if (DateTime.Now.Second % 2 == 0) 	// Stop spinning after 2 seconds
            {
                timerSpin.Stop();
                btnSpin.Enabled = true;

                // return multiplier so i could display the multiplier after the spin
                var (wins,mltplyr) = slotMachine.CheckResult();
                int winnings = wins;	// Check the result and update the UI accordingly
                int multiplier = mltplyr;
                slotMachine.UpdateBalance(winnings);

                // Update the result label
                if (winnings > 0)
                {
                    lblResult.Text = "🎉 WIN! You earned P" + winnings + " 🎉";
                    lblResult.ForeColor = Color.Green;
                }
                else
                {
                    lblResult.Text = "No luck this time!";
                    lblResult.ForeColor = Color.Red;
                }

                lblBalance.Text = "Balance: P" + slotMachine.Balance;
                txtStake.Clear();
            }


        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (stake < slotMachine.Balance) // Prevent stake from exceeding balance
            {
                stake++;
                txtStake.Text = stake.ToString();
            }
            else
            {
                MessageBox.Show("Stake cannot exceed your balance!", "Invalid Stake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtStake_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the text as an integer
            if (int.TryParse(txtStake.Text, out int newStake))
            {
                // Make sure the new stake is within the valid range
                if (newStake >= 0 && newStake <= slotMachine.Balance)
                {
                    stake = newStake; // Update the stake value
                }
                else
                {
                    // Show a message if the stake is invalid and revert the text box to the last valid value
                    MessageBox.Show("Please enter a valid stake amount (between 0 and your balance).", "Invalid Stake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStake.Text = stake.ToString(); // Revert to last valid stake
                }
            }
       
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (stake > 0) // Prevent negative stake
            {
                stake--;
                txtStake.Text = stake.ToString();
            }
            else
            {
                MessageBox.Show("Stake cannot be less than 0!", "Invalid Stake", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMaxBet_Click(object sender, EventArgs e)
        {
            stake = slotMachine.Balance; 
            txtStake.Text = stake.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
