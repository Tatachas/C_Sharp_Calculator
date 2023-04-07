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
        int firstNum, secondNum, finalNum;
        string expression = "";

        public Calculator()
        {
            InitializeComponent();
        }
        private void Calculator_Load(object sender, EventArgs e) 
        {
            this.BackColor = Color.DarkGray;
            textBox1.ReadOnly = true;
            textBox1.Font = new Font("Arial", 24, FontStyle.Bold);

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

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            firstNum += int.Parse(textBox1.Text);
            textBox1.Text = "";
            expression += firstNum + "/";

        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            firstNum += int.Parse(textBox1.Text);
            textBox1.Text = "";
            expression += firstNum + "*";
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            firstNum += int.Parse(textBox1.Text);
            textBox1.Text = "";
            expression += firstNum + "-";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            firstNum += int.Parse(textBox1.Text);
            textBox1.Text = "";
            expression += firstNum + "+";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            firstNum = 0;
            secondNum = 0;
            expression = "";
            textBox1.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            secondNum += int.Parse(textBox1.Text);
            expression += secondNum;

            DataTable table = new DataTable();
            try
            {
                object result = table.Compute(expression, "");
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error";
            }
        }
    }
}
