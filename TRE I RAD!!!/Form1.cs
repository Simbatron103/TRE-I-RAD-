﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRE_I_RAD___
{
    public partial class Form1 : Form
    {
        int turn = 1;
        int click1 = 1;
        int player1 = 0;
        int player2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void display()
        {
            if (turn % 2 != 0)
            {
                displayturn.Text = "Player 1";
            }
            else
            {
                displayturn.Text = "Player 2";
            }
        }
        public void checkit()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    button1.BackColor = Color.Green;
                  
                    button2.BackColor = Color.Green;
               
                    button3.BackColor = Color.Green;
                
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button5.Text && button5.Text == button6.Text)
                {
                    button4.BackColor = Color.Green;

                    button5.BackColor = Color.Green;

                    button6.BackColor = Color.Green;

                    if (button4.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button8.Text && button8.Text == button9.Text)
                {
                    button7.BackColor = Color.Green;

                    button8.BackColor = Color.Green;

                    button9.BackColor = Color.Green;

                    if (button7.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button5.Text && button5.Text == button9.Text)
                {
                    button1.BackColor = Color.Green;

                    button5.BackColor = Color.Green;

                    button9.BackColor = Color.Green;

                    if (button5.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == button5.Text && button5.Text == button7.Text)
                {
                    button3.BackColor = Color.Green;

                    button5.BackColor = Color.Green;

                    button7.BackColor = Color.Green;

                    if (button5.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button4.Text && button4.Text == button7.Text)
                {
                    button1.BackColor = Color.Green;

                    button4.BackColor = Color.Green;

                    button7.BackColor = Color.Green;

                    if (button4.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button5.Text && button5.Text == button8.Text)
                {
                    button2.BackColor = Color.Green;

                    button5.BackColor = Color.Green;

                    button8.BackColor = Color.Green;

                    if (button5.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button6.Text && button6.Text == button9.Text)
                {
                    button3.BackColor = Color.Green;

                    button6.BackColor = Color.Green;

                    button9.BackColor = Color.Green;

                    if (button6.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }
                    cleargame();
                }
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (click1 > 0)
                {
                    if (turn % 2 != 0)
                    {
                        button1.Text = "X";
                    }
                    else
                    {
                        button1.Text = "O";
                    }
                    turn++;
                    click1++;
                }
                else
                {
                    button1.Text = button1.Text;
                }
                display();
                checkit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (click1 > 0)
                {
                    if (turn % 2 != 0)
                    {
                        button2.Text = "X";
                    }
                    else
                    {
                        button2.Text = "O";
                    }
                    turn++;
                    click1++;
                }
                else
                {
                    button2.Text = button2.Text;
                }
                display();
                checkit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (click1 > 0)
                {
                    if (turn % 2 != 0)
                    {
                        button3.Text = "X";
                    }
                    else
                    {
                        button3.Text = "O";
                    }
                    turn++;
                    click1++;
                }
                else
                {
                    button3.Text = button3.Text;
                }
                display();
                checkit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (click1 > 0)
                {
                    if (turn % 2 != 0)
                    {
                        button4.Text = "X";
                    }
                    else
                    {
                        button4.Text = "O";
                    }
                    turn++;
                    click1++;
                }
                else
                {
                    button4.Text = button4.Text;
                }
                display();
                checkit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (click1 > 0)
                {
                    if (turn % 2 != 0)
                    {
                        button5.Text = "X";
                    }
                    else
                    {
                        button5.Text = "O";
                    }
                    turn++;
                    click1++;
                }
                else
                {
                    button5.Text = button5.Text;
                }
                display();
                checkit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                if (click1 > 0)
                {
                    if (turn % 2 != 0)
                    {
                        button6.Text = "X";
                    }
                    else
                    {
                        button6.Text = "O";
                    }
                    turn++;
                    click1++;
                }
                else
                {
                    button6.Text = button6.Text;
                }
                display();
                checkit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                if (click1 > 0)
                {
                    if (turn % 2 != 0)
                    {
                        button7.Text = "X";
                    }
                    else
                    {
                        button7.Text = "O";
                    }
                    turn++;
                    click1++;
                }
                else
                {
                    button7.Text = button7.Text;
                }
                display();
                checkit();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                if (click1 > 0)
                {
                    if (turn % 2 != 0)
                    {
                        button8.Text = "X";
                    }
                    else
                    {
                        button8.Text = "O";
                    }
                    turn++;
                    click1++;
                }
                else
                {
                    button8.Text = button8.Text;
                }
                display();
                checkit();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                if (click1 > 0)
                {
                    if (turn % 2 != 0)
                    {
                        button9.Text = "X";
                    }
                    else
                    {
                        button9.Text = "O";
                    }
                    turn++;
                    click1++;
                }
                else
                {
                    button9.Text = button9.Text;
                }
                display();
                checkit();
            }
        }
                  public void cleargame()
        {
            turn = 1;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cleargame();   
        }

        private void button11_Click(object sender, EventArgs e)
        {
            player1 = 0;
            player2 = 0;
            player1score.Text = player1.ToString();
            player2score.Text = player2.ToString();
        }
    }
}