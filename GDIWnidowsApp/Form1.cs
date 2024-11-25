using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIWnidowsApp
{
    public partial class Form1 : Form
    {
        public Point Point1;
        public Point Point2;
        public int shape = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void onClickExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onFileSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog(this);
        }

        private void OnFileOpen(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(this);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
             Point1 = new Point(e.X, e.Y);
            //MessageBox.Show("Down Event");
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            Point2 = new Point(e.X, e.Y);
            //MessageBox.Show("Up Event");

            Pen thePen = new Pen(Color.Red);

            Graphics g = this.CreateGraphics();


            switch (shape)
            {
                case 1:
                    g.DrawLine(thePen, Point1, Point2);
                    break;
                case 2:
                    {
                        float width = Point2.X - Point1.X;
                        float height = Point2.Y - Point1.Y;
                        g.DrawRectangle(thePen, Point1.X, Point1.Y, width, height);
                    }
                    break;
            }


            // g.DrawLine(thePen, Point1 ,Point2);
            
          

        }

        private void shapeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
