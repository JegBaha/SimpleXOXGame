namespace StajTicTacToe
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
            this.playerText = new System.Windows.Forms.Label();
            this.computerText = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerWin = new System.Windows.Forms.Label();
            this.computerWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerText
            // 
            this.playerText.AutoSize = true;
            this.playerText.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playerText.ForeColor = System.Drawing.Color.Lime;
            this.playerText.Location = new System.Drawing.Point(17, 9);
            this.playerText.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.playerText.Name = "playerText";
            this.playerText.Size = new System.Drawing.Size(83, 28);
            this.playerText.TabIndex = 0;
            this.playerText.Text = "Player:";
            this.playerText.Click += new System.EventHandler(this.playerText_Click);
            // 
            // computerText
            // 
            this.computerText.AutoSize = true;
            this.computerText.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.computerText.ForeColor = System.Drawing.Color.Red;
            this.computerText.Location = new System.Drawing.Point(732, 387);
            this.computerText.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.computerText.Name = "computerText";
            this.computerText.Size = new System.Drawing.Size(125, 28);
            this.computerText.TabIndex = 1;
            this.computerText.Text = "Computer:";
            this.computerText.Click += new System.EventHandler(this.computerText_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(353, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 77);
            this.button2.TabIndex = 3;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.playerClickThing);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(513, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 77);
            this.button3.TabIndex = 4;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.playerClickThing);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(193, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 77);
            this.button1.TabIndex = 5;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.playerClickThing);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(193, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 77);
            this.button4.TabIndex = 8;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.playerClickThing);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(513, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 77);
            this.button5.TabIndex = 7;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.playerClickThing);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(353, 176);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 77);
            this.button6.TabIndex = 6;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.playerClickThing);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(193, 259);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 77);
            this.button7.TabIndex = 11;
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.playerClickThing);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(513, 259);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(154, 77);
            this.button8.TabIndex = 10;
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.playerClickThing);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(353, 259);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 77);
            this.button9.TabIndex = 9;
            this.button9.Text = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.playerClickThing);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(877, 9);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(26, 28);
            this.button10.TabIndex = 12;
            this.button10.Text = "X";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.computerMove);
            // 
            // playerWin
            // 
            this.playerWin.AutoSize = true;
            this.playerWin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playerWin.ForeColor = System.Drawing.Color.Lime;
            this.playerWin.Location = new System.Drawing.Point(107, 9);
            this.playerWin.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.playerWin.Name = "playerWin";
            this.playerWin.Size = new System.Drawing.Size(0, 28);
            this.playerWin.TabIndex = 13;
            // 
            // computerWin
            // 
            this.computerWin.AutoSize = true;
            this.computerWin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.computerWin.ForeColor = System.Drawing.Color.Red;
            this.computerWin.Location = new System.Drawing.Point(858, 387);
            this.computerWin.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.computerWin.Name = "computerWin";
            this.computerWin.Size = new System.Drawing.Size(25, 28);
            this.computerWin.TabIndex = 14;
            this.computerWin.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 424);
            this.Controls.Add(this.computerWin);
            this.Controls.Add(this.playerWin);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.computerText);
            this.Controls.Add(this.playerText);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "w";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerText;
        private System.Windows.Forms.Label computerText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerWin;
        private System.Windows.Forms.Label computerWin;
    }
}

