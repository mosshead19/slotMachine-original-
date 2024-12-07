namespace slotMachine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.TextBox();
            this.timerSpin = new System.Windows.Forms.Timer(this.components);
            this.lblResult = new System.Windows.Forms.TextBox();
            this.txtStake = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMaxBet = new System.Windows.Forms.Button();
            this.picBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(212, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(424, 190);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 87);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(318, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(318, 288);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(100, 35);
            this.btnSpin.TabIndex = 4;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(305, 93);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(153, 22);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance";
            // 
            // timerSpin
            // 
            this.timerSpin.Tick += new System.EventHandler(this.timerSpin_Tick_1);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(273, 121);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(211, 22);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            // 
            // txtStake
            // 
            this.txtStake.Location = new System.Drawing.Point(318, 364);
            this.txtStake.Name = "txtStake";
            this.txtStake.Size = new System.Drawing.Size(100, 22);
            this.txtStake.TabIndex = 7;
            this.txtStake.Text = "Bet";
            this.txtStake.TextChanged += new System.EventHandler(this.txtStake_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(339, 55);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 22);
            this.lblUserName.TabIndex = 8;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(424, 363);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(48, 23);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(264, 364);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(48, 23);
            this.btnMinus.TabIndex = 10;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMaxBet
            // 
            this.btnMaxBet.Location = new System.Drawing.Point(320, 398);
            this.btnMaxBet.Name = "btnMaxBet";
            this.btnMaxBet.Size = new System.Drawing.Size(75, 23);
            this.btnMaxBet.TabIndex = 11;
            this.btnMaxBet.Text = "MAX";
            this.btnMaxBet.UseVisualStyleBackColor = true;
            this.btnMaxBet.Click += new System.EventHandler(this.btnMaxBet_Click);
            // 
            // picBoxBackground
            // 
            this.picBoxBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picBoxBackground.Location = new System.Drawing.Point(195, 41);
            this.picBoxBackground.Name = "picBoxBackground";
            this.picBoxBackground.Size = new System.Drawing.Size(371, 397);
            this.picBoxBackground.TabIndex = 12;
            this.picBoxBackground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaxBet);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtStake);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBoxBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.TextBox lblBalance;
        private System.Windows.Forms.Timer timerSpin;
        private System.Windows.Forms.TextBox lblResult;
        private System.Windows.Forms.TextBox txtStake;
        private System.Windows.Forms.TextBox lblUserName;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMaxBet;
        private System.Windows.Forms.PictureBox picBoxBackground;
    }
}

