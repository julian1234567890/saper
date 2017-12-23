using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    public partial class Form1 : Form
    {

        Cell[,] cells = new Cell[20, 20];

        public Form1()
        {
            InitializeComponent();

            for(int j=0;j<20;j++)
            {
                for(int i=0;i<20;i++)
                {
                    cells[i, j] = new Cell();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);

            for(int x=0; x<400;x+=20)
            {
                 

                g.DrawLine(pen, x, 0, x, 400);
            }

            for (int y = 0; y < 400; y += 20)
            {


                g.DrawLine(pen, 0, y , 400, y);
            }


           

            for (int j = 0; j < 20; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    g.DrawString($"{cells[i, j].Bombs}", new Font(FontFamily.GenericMonospace,13), Brushes.Red, i*20, j*20); 
                }
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }


        private void SetBombs(int i,int j)
        {
            if (cells[i - 1, j - 1].Bombs != -1)
                cells[i - 1, j - 1].Bombs++;
            if (cells[i - 1, j].Bombs != -1)
                cells[i - 1, j].Bombs++;
            if (cells[i - 1, j + 1].Bombs != -1)
                cells[i - 1, j + 1].Bombs++;
            if (cells[i, j - 1].Bombs != -1)
                cells[i, j - 1].Bombs++;
            if (cells[i, j + 1].Bombs != -1)
                cells[i, j + 1].Bombs++;
            if (cells[i + 1, j - 1].Bombs != -1)
                cells[i + 1, j - 1].Bombs++;
            if (cells[i + 1, j].Bombs != -1)
                cells[i + 1, j].Bombs++;
            if (cells[i + 1, j + 1].Bombs != -1)
                cells[i + 1, j + 1].Bombs++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for ( j = 0; j < 20; j++)
            {
                for ( i = 0; i < 20; i++)
                {
                        cells[i, j].Bombs = 0; /////(cells[i,j].Bombs != -1 === +1. -1 ++1
                }
            }

            cells[5, 3].Bombs = -1;
            cells[4, 5].Bombs = -1;
            cells[1, 7].Bombs = -1;

           
            SetBombs(5, 3);
            SetBombs(4, 5);
            SetBombs(1, 7);

            pictureBox1.Invalidate();


        }

        private void button5_Click(object sender, EventArgs e)
        {
                        
        }
    }
}