using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajTicTacToe
{
    public partial class Form1 : Form
    {
        public enum user
        {
            X, O
        }
        user currentUser;
        Random random= new Random();
        int playerWinCount = 0;
        int computerWinCount = 0;
        List<Button> buttons = new List<Button>();
        
        public Form1()
        {
          
           
            InitializeComponent();
            restartThing();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playerText_Click(object sender, EventArgs e)
        {
           
        }

        private void computerText_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void computerMove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {

                int index=random.Next(buttons.Count);
                buttons[index].Enabled = true;
                currentUser = user.O;
                buttons[index].Text = currentUser.ToString();
                buttons[index].BackColor = Color.Red;
                buttons.RemoveAt(index);
                checkThing();
                gameTimer.Stop();
                
            }

        }

        private void playerClickThing(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            currentUser = user.X;
            button.Text = currentUser.ToString();
            button.Enabled = false;
            button.BackColor = Color.Green;
            buttons.Remove(button);
            checkThing();
            gameTimer.Start();
        }
        private void checkThing()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" || button4.Text == "X" && button5.Text == "X" && button6.Text == "X" || button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || button6.Text == "X" && button2.Text == "X" && button9.Text == "X" || button3.Text == "X" && button5.Text == "X" && button8.Text == "X" || button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                gameTimer.Stop();
                MessageBox.Show("You win!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                playerWinCount++;
                playerWin.Text=playerWinCount.ToString();
                restartThing();
            }else if(button1.Text == "O" && button2.Text == "O" && button3.Text == "O" || button4.Text == "O" && button5.Text == "O" && button6.Text == "O" || button7.Text == "O" && button8.Text == "O" && button9.Text == "O" || button6.Text == "O" && button2.Text == "O" && button9.Text == "O" || button3.Text == "O" && button5.Text == "O" && button8.Text == "O" || button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                gameTimer.Stop();
                MessageBox.Show("Computer wins!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                computerWinCount++;
                computerWin.Text =computerWinCount.ToString();
                restartThing();
            }
        }
        private void restartThing()
        {
           buttons = new List<Button>{ button1, button2, button3, button4, button5, button6, button7, button8, button8, button9 };

            foreach(Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor=DefaultBackColor;
            }
                
        }
    }
}
