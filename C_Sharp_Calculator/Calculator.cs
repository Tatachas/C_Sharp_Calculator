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
        private void Calculator_Load(object sender, EventArgs e) 
        {
            this.BackColor = Color.DarkGray;

            foreach (Control control in Controls)
            {
                if (control is Button button && char.IsDigit(button.Text[0]))
                {
                    button.Click += numberButtonEvent;
                }
            }

        }


        public void panel2_Paint(object sender, PaintEventArgs e)
        {
            Rectangle displayRec = new Rectangle(10, 10, 600, 100);
            e.Graphics.DrawRectangle(blck, displayRec);
            e.Graphics.FillRectangle(Brushes.LightGray, displayRec);
            

        }

        private void numberButtonEvent(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
