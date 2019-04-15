using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EnglishLearn
{
    public partial class Form1 : Form
    {
        private bool isMouseDown = false;
        private Point mouseOffset;
        private CheckWords check = new CheckWords();
        private AddWords add = new AddWords();
        private LearnWords learn = new LearnWords();

        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("Dictionary.dat"))
                (File.Create("Dictionary.dat")).Close();
            controlPanelCheck.Controls.Add(check);
            check.Dock = DockStyle.Fill;
            check.root = this;
            controlPanelAdd.Controls.Add(add);
            add.Dock = DockStyle.Fill;
            add.root = this;
            controlPanelLearn.Controls.Add(learn);
            learn.Dock = DockStyle.Fill;
            learn.root = this;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;
            Opacity = 0.9;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
                Opacity = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            movingPanel.BackColor = Color.FromArgb(255, 40, 30, 40);
            controlPanelCheck.Visible = true;
            controlPanelCheck.BringToFront();
            check.renewVars();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movingPanel.BackColor = Color.FromArgb(255, 40, 60, 55);
            controlPanelAdd.Visible = true;
            controlPanelAdd.BringToFront();
            add.getStartString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            learn.getStartString();
            learn.fillTable();
            movingPanel.BackColor = Color.FromArgb(255, 39, 106, 2);
            controlPanelLearn.Visible = true;
            controlPanelLearn.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void escape(int who)
        {
            switch(who)
            {
                case 0: 
                    controlPanelCheck.Visible = false;
                    break;
                case 1:
                    controlPanelAdd.Visible = false;
                    break;
                case 2:
                    controlPanelLearn.Visible = false;
                    break;
                default: 
                    break;
            }
            movingPanel.BackColor = Color.FromArgb(255, 50, 51, 58);
        }
    }
}
