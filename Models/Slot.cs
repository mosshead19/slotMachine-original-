using slotMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine.Models
{
    public class Slot
    {
        private int balance;
        private int stake;
        private readonly Reel[] reels;

        public Slot(int initialBalance, PictureBox[] pictureBoxes, Theme theme)
        {
            this.balance = initialBalance;
            this.reels = new Reel[pictureBoxes.Length];
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                reels[i] = new Reel(pictureBoxes[i], theme);
            }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int Stake
        {
            get { return stake; }
            set { stake = value; }
        }

        public void Spin()
        {
            // Spin each reel
            foreach (var reel in reels)
            {
                reel.Spin();
            }
        }

        public (int, int) CheckResult()
        {
            int winnings = 0;
            int multiplier = 0;

            Random random = new Random();
            bool allowWin = random.Next(0, 100) < 60; // 50% chance to allow a win

            if (reels[0].Symbol == reels[1].Symbol && reels[1].Symbol == reels[2].Symbol && allowWin)
            {
                multiplier = 10; // Jackpot multiplier
                winnings = stake * multiplier;
            }
            else if ((reels[0].Symbol == reels[1].Symbol || reels[1].Symbol == reels[2].Symbol || reels[0].Symbol == reels[2].Symbol) && allowWin)
            {
                multiplier = 2; // Partial match multiplier
                winnings = stake * multiplier;
            }

            return (winnings, multiplier);
        }


        public void UpdateBalance(int winnings)
        {
            Balance += winnings;
        }
    }
}
