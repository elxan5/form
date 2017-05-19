using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Left = 0;
            int k = 1;


            for (int i = 0; i <= 3; i++)
            {

                for (int j = 1; j < 7; j++)
                {
                    Shaper shpr = new Shaper(60, 40, i * 60, i * 60, k.ToString(), new Button());
       
                    Button mybtn = new Button();
                    Controls.Add(mybtn);
                    mybtn.Left += 100 + j * 60;

                    mybtn.Top += 100 + i * 60;
                    mybtn.Text = Convert.ToString(k);
                    mybtn.Width = 60;
                    mybtn.Height = 40;
                    k++;
                    Controls.Add(mybtn);


                }
            }
        }

        public  class Shaper
        {
            public int Width;
            public int Height;
            public int Left;
            public int Top;
            public string Text;
            public Button Btn;
           
            public Shaper(int width,int height,int left,int top,string text,Button btn)
            {
                this.Width = width;
                this.Height = height;
                this.Left = left;
                this.Top = top;
                this.Text = text;
                this.Btn = btn;

            }
        }
    }
}
