using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XOGame.Properties;

namespace XOGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 15;

            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(whitePen, 400, 460, 1050, 460);

            //draw Vertical lines
            e.Graphics.DrawLine(whitePen, 610, 140, 610, 620);
            e.Graphics.DrawLine(whitePen, 840, 140, 840, 620);
        }

        public enum enPlayer
        {
            Player1,
            Player2
        };

        enPlayer CurrentPlayer = enPlayer.Player1;
        byte GameCounter = 0;

        public void UpdateInfo(enPlayer Player, Button btn)
        {
            if (Player == enPlayer.Player1)
            {
                btn.Image = Resources.X;
                btn.Tag = "X";
                lblTurn.Text = "Player 2";
                CurrentPlayer = enPlayer.Player2;
            }

            else
            {
                btn.Image = Resources.O;
                btn.Tag = "O";
                lblTurn.Text = "Player 1";
                CurrentPlayer = enPlayer.Player1;
            }

            GameCounter++;
        }

        public void EndGame()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

            lblTurn.Text = "Game Over";

            MessageBox.Show("Game Over", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            return btn1.Tag.ToString() != "?"
                  && btn1.Tag.ToString() == btn2.Tag.ToString()
                  && btn2.Tag.ToString() == btn3.Tag.ToString() ? true : false;
        }

        public void UpdateWinner()
        {
            switch (CurrentPlayer)
            {
                case enPlayer.Player1:
                    lblWinner.Text = "Player 2";
                    EndGame();
                    break;

                case enPlayer.Player2:
                    lblWinner.Text = "Player 1";
                    EndGame();
                    break;
            }
        }

        public void VisualizeResult(Button btn1, Button btn2, Button btn3)
        {
            btn1.BackColor = Color.GreenYellow;
            btn2.BackColor = Color.GreenYellow;
            btn3.BackColor = Color.GreenYellow;
        }

        public void GetFinalResult()
        {
            if (CheckValues(button1, button2, button3))
            {
                VisualizeResult(button1, button2, button3);
                UpdateWinner();

            }

            else if (CheckValues(button4, button5, button6))
            {
                VisualizeResult(button4, button5, button6);
                UpdateWinner();
            }

            else if (CheckValues(button7, button8, button9))
            {
                VisualizeResult(button7, button8, button9);
                UpdateWinner();
            }

            else if (CheckValues(button1, button4, button7))
            {
                VisualizeResult(button1, button4, button7);
                UpdateWinner();
            }

            else if (CheckValues(button2, button5, button8))
            {
                VisualizeResult(button2, button5, button8);
                UpdateWinner();
            }

            else if (CheckValues(button3, button6, button9))
            {
                VisualizeResult(button3, button6, button9);
                UpdateWinner();
            }

            else if (CheckValues(button1, button5, button9))
            {
                VisualizeResult(button1, button5, button9);
                UpdateWinner();
            }

            else if (CheckValues(button3, button5, button7))
            {
                VisualizeResult(button3, button5, button7);
                UpdateWinner();
            }

            else if (GameCounter == 9)
            {
                lblWinner.Text = "Draw";
                EndGame();
            }
        }

        //public void UpdateWinner()
        //{
        //    if (CheckValues(button1, button2, button3)
        //        || CheckValues(button4, button5, button6)
        //        || CheckValues(button7, button8, button9)
        //        || CheckValues(button1, button4, button7)
        //        || CheckValues(button2, button5, button8)
        //        || CheckValues(button3, button6, button9)
        //        || CheckValues(button1, button5, button9)
        //        || CheckValues(button3, button5, button7))
        //    {
        //        switch (CurrentPlayer)
        //        {
        //            case enPlayer.Player1:
        //                lblWinner.Text = "Player 2";
        //                EndGame();
        //                break;

        //            case enPlayer.Player2:
        //                lblWinner.Text = "Player 1";
        //                EndGame();
        //                break;
        //        }
        //    }

        //    else if (GameCounter == 9)
        //    {
        //        lblWinner.Text = "Draw";
        //        EndGame();
        //    }
        //}

        public void UpdateImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (CurrentPlayer)
                {
                    case enPlayer.Player1:
                        UpdateInfo(enPlayer.Player1, btn);
                        GetFinalResult();
                        break;

                    case enPlayer.Player2:
                        UpdateInfo(enPlayer.Player2, btn);
                        GetFinalResult();
                        break;

                }
            }

            else
            {
                MessageBox.Show("This cell is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResetButton(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = Color.Black;
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
        }
        public void LoadDefaultValues()
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            lblTurn.Text = "Player 1";
            CurrentPlayer = enPlayer.Player1;

            lblWinner.Text = "In Progress";
            GameCounter = 0;

        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            LoadDefaultValues();
        }

        private void button_click(object sender, EventArgs e)
        {
            UpdateImage((Button)sender);
        }
    }
}
