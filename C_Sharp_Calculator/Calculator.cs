using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blck = new Pen(Color.Gray, 5);
            
            int calcRecWidth = 4;
            int calcRecHeight = 5;
            Rectangle[][] calcRecs = new Rectangle[calcRecWidth][];

            for(int i = 0; i < 4; i++)
            {
                calcRecs[i] = new Rectangle[calcRecHeight];
            }

            for(int w = 0; w < calcRecWidth; w++)
            {
                for(int h = 0; h < calcRecHeight; h++)
                {
                    calcRecs[w][h] = new Rectangle(w * 100, h * 100, 100, 100);
                    e.Graphics.DrawRectangle(blck, calcRecs[w][h]);
                    e.Graphics.FillRectangle(Brushes.LightGray,calcRecs[w][h]);

                }
            }
        }


    }
}
