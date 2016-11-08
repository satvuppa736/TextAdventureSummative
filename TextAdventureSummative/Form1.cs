using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TextAdventureSummative
{
    public partial class Form1 : Form
    {
        int scene = 0;
        Random randGen = new Random();
        int attackValue, stealthValue;
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You wake up in a dark room with a small trap door and a single torch. Do you go into the trap door or stay in the room?";
            redLabel.Text = "LEAVE";
            blueLabel.Text = "STAY";
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }

                else if (scene == 1)
                {
                    scene = 3;
                }

                else if (scene == 3)
                {
                    Thread.Sleep(10000);

                    attackValue = randGen.Next(1, 11);
                    if (attackValue >= 4)
                    {
                        scene = 6;
                    }
                    else if (attackValue < 4)
                    {
                        scene = 5;
                    }
                }
                else if (scene == 5)
                {
                    scene = 26;
                }
                else if (scene == 6)
                {
                    scene = 7;
                }
                else if (scene == 7 || scene == 9)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 12 || scene == 14)
                {
                    scene = 15;
                }
                else if (scene == 15)
                {
                    scene = 17;
                }
                else if (scene == 17)
                {
                    scene = 18;
                }
                else if (scene == 18 || scene == 19 || scene == 21)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 16;
                }

                else if (scene == 26)
                {
                    scene = 0;
                }
                    
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }

                else if (scene == 2)
                {
                    scene = 26;
                }

                else if (scene == 1)
                {
                    scene = 4;
                }

                else if (scene == 4)
                {
                    scene = 26;
                }

                else if (scene == 6)
                {
                    scene = 8;
                }

                else if (scene == 8)
                {
                    scene = 26;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }

                else if (scene == 11)
                {
                    scene = 26;
                }

                else if (scene == 12)
                {
                    attackValue = randGen.Next(1, 11);
                    if (attackValue >= 4)
                    {
                        scene = 14;
                    }
                    else if (attackValue < 4)
                    {
                        scene = 13;
                    }
                }
                else if (scene == 13)
                {
                    scene = 26;
                }
                else if (scene == 15)
                {
                    scene = 16;
                }

                else if (scene == 16)
                {
                    scene = 26;
                }

                else if (scene == 17)
                {
                    stealthValue = randGen.Next(1, 11);
                    if (stealthValue >= 4)
                    {
                        scene = 21;
                    }
                    else if (stealthValue < 4)
                    {
                        scene = 20;
                    }
                }

                else if (scene == 20)
                {
                    scene = 26;
                }

                else if (scene == 23)
                {
                    scene = 25;
                }

                else if (scene == 25)
                {
                    scene = 26;
                } 

                else if (scene == 26)
                {
                    Application.Exit();
                }
            }

            else if (e.KeyCode == Keys.Space)
            {
                if (scene == 6)
                {
                    scene = 9;
                }
                
                else if (scene == 17)
                {
                    attackValue = randGen.Next(1, 11);
                    if (attackValue >= 4)
                    {
                        scene = 19;
                    }
                    else if (attackValue < 4)
                    {
                        scene = 22;
                    }

                    else if (scene == 22)
                    {
                        scene = 26;
                    }
                }
            }

            switch (scene)
            {
                case 0:
                    outputLabel.Text = "You wake up in a dark room with a small trap door and a single torch. Do you go into the trap door or stay in the room?";
                    redLabel.Text = "LEAVE";
                    blueLabel.Text = "STAY";
                    break;
                case 1:
                    outputLabel.Text = "You drop down into a long hallway and seea light in the distance. Do you return to grab your torch or start walking?";
                    redLabel.Text = "GET TORCH";
                    blueLabel.Text = "WALK";
                    break;
                case 2:
                    outputLabel.Text = "You crawl into a ball and win! Congrats!";
                    redLabel.Text = "";
                    blueLabel.Text = "CONTINUE";
                    break;
                case 3:
                    outputLabel.Text = "You grab your torch and slowly walk down the hallway. You jump the pit. A Native jumps out and attacks you. You fight back.";
                    redLabel.Text = "PLEASE WAIT";
                    blueLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You start walking but end up falling into a pit of spikes left by the Natives";
                    redLabel.Text = "";
                    blueLabel.Text = "CONTINUE";
                    break;










            }
        }
    }
}
