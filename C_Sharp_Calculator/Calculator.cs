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
        Pen blck = new Pen(Color.Gray, 2);
        //int disNumOne, disNumTwo;
        public Calculator()
        {
            InitializeComponent();

        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            int calcRecRow = 4;
            int calcRecCol = 5;
            int count = 0;
            int funCount = 0;
            string[] functions = new string[] { "=","sand porch","coomies","+"
                ,"-","*","/","rrger","dawda","the mechanism"} ;
            List<Button> butonList = new List<Button>();
            Rectangle[][] calcRecs = new Rectangle[calcRecRow][];   
            


            for (int i = 0; i < 4; i++)
            {
                calcRecs[i] = new Rectangle[calcRecCol];
            }
            

            for(int c = calcRecCol-1; c >= 0; c--)
            {
                for(int r = 0; r < calcRecRow; r++)
                {
                    calcRecs[r][c] = new Rectangle(10 + (r * 100),10 + (c * 100), 100, 100);
                    e.Graphics.DrawRectangle(blck, calcRecs[r][c]);
                    e.Graphics.FillRectangle(Brushes.LightGray,calcRecs[r][c]);


                    Button calcbut = new Button();
                    calcbut.Location = new Point(225 + calcRecs[r][c].X, 174 + calcRecs[r][c].Y);
                    calcbut.Size = new Size(103, 103);
                    calcbut.Font = new Font("Arial", 12, FontStyle.Bold);
                    calcbut.Visible = true;

                    if (count == 0 && r == 1 || count == 1 && r == 3)
                    {
                        calcbut.Text = "" + functions[funCount];
                        funCount++;
                    }


                    else if (r > 0 && c > 0)
                    {

                        calcbut.Text = count + "";
                        count++;

                        

                    }
                    else
                    {
                        calcbut.Text = "" + functions[funCount];
                        funCount++;

                        
                    }

                    Controls.Add(calcbut);
                    calcbut.BringToFront();

                    butonList.Add(calcbut);





                }
            }

            //butonList[0].Click += buttonNumber(sender, e);
            








        }

       

        public void panel2_Paint(object sender, PaintEventArgs e)
        {
            Rectangle displayRec = new Rectangle(10, 10, 600, 100);
            e.Graphics.DrawRectangle(blck, displayRec);
            e.Graphics.FillRectangle(Brushes.LightGray, displayRec);
            

        }

        /*public void buttonNumber(object sender, PaintEventArgs e)
        {

        } */

    }
}
