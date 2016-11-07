using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                }
                    
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {

            }
        }
    }
}
