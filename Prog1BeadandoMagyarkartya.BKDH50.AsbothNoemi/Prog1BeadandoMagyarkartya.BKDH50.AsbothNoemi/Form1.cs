using Prog1BeadandoMagyarkartya.BKDH50.AsbothNoemi.mogel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1BeadandoMagyarkartya.BKDH50.AsbothNoemi
{
    public partial class Form1 : Form
    {
        private CardHandler ch;
        private CardHandler cardHandler;
        private bool runing = true;
        public Form1()
        {
            InitializeComponent();
            ch = new CardHandler(this);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            button1.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Enabled = true;
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool eror=false;
            int raw = -1;
            int column = -1;
            for (int i = 0; i < 7; i++)
            {
                raw = i;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    column = i2;
                    var result = ch.test(raw, column);
                    if (result != null)
                    {
                        eror = true;
                        var newPoint1 = ch.RandomPoint();
                        var newPoint2 = ch.RandomPoint();
                        ch.exchangeCard(newPoint1[0], newPoint1[1], newPoint2[0], newPoint2[1]);
                        Thread.Sleep(200);

                    }
                   
                }

            }
            if (!eror)
            {
                label3.Text = "jo megoldás";
                timer1.Stop();  
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bool eror = false;
            int raw = -1;
            int column = -1;
            for (int i = 0; i < 7; i++)
            {
                raw = i;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    column = i2;
                    var result = ch.test(raw, column);
                    if (result != null)
                    {
                        eror = true;
                       
                        var newPoint2 = ch.RandomPoint();
                        ch.exchangeCard(column,raw, newPoint2[0], newPoint2[1]);
                        Thread.Sleep(200);

                    }

                }

            }
            if (!eror)
            {
                label3.Text = "jo megoldás";
                timer1.Stop();
            }
        }
    }
}
