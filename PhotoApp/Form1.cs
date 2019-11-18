using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoApp
{
    public partial class Form1 : Form
    {
        private System.Drawing.Bitmap m_Bitmap;
        private System.Drawing.Bitmap m_Undo;
        private double Zoom = 1.0;


        public Form1()
        {
            InitializeComponent();
            m_Bitmap = new Bitmap(2, 2);
          
           
        }

        //Hien thi anh
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(m_Bitmap, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y, (int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom)));
        }
        // Mo file 
        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                m_Bitmap = (Bitmap)Bitmap.FromFile(openFile.FileName, false);
               
                this.AutoScroll = true;
                this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
                this.Invalidate();
            }
        }

        //Luu file
        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = "c:\\";
            saveFile.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;

            if (DialogResult.OK == saveFile.ShowDialog())
            {
                m_Bitmap.Save(saveFile.FileName);
            }
        }

        //Exit
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Filter
        private void gray_Click(object sender, EventArgs e)
        {
            m_Undo = (Bitmap)m_Bitmap.Clone();
            if (BitmapFilter.GrayScale(m_Bitmap))
                this.Invalidate();
        }

        private void bright_Click(object sender, EventArgs e)
        {
            Parameter dlg = new Parameter();
            dlg.nValue = 0;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                m_Undo = (Bitmap)m_Bitmap.Clone();
                if (BitmapFilter.Brightness(m_Bitmap, dlg.nValue))
                    this.Invalidate();
            }
        }

        //Zoom
        private void zoom25_Click(object sender, EventArgs e)
        {
            Zoom = .25;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
        }

        private void zoom50_Click(object sender, EventArgs e)
        {
            Zoom = .5;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
        }

        private void zoom100_Click(object sender, EventArgs e)
        {
            Zoom = 1.0;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
        }

        private void zoom150_Click(object sender, EventArgs e)
        {
            Zoom = 1.5;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
        }

        private void zoom200_Click(object sender, EventArgs e)
        {
            Zoom = 2.0;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
        }

        private void zoom300_Click(object sender, EventArgs e)
        {
            Zoom = 3.0;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
        }

        private void undo_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)m_Bitmap.Clone();
            m_Bitmap = (Bitmap)m_Undo.Clone();
            m_Undo = (Bitmap)temp.Clone();
            this.Invalidate();
        }

        private void invert_Click(object sender, EventArgs e)
        {
            m_Undo = (Bitmap)m_Bitmap.Clone();
            if (BitmapFilter.Invert(m_Bitmap))
                this.Invalidate();
        }

        private void color_Click(object sender, EventArgs e)
        {
            RGB dlg = new RGB();
            dlg.red = dlg.green = dlg.blue = 0;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                m_Undo = (Bitmap)m_Bitmap.Clone();
                if (BitmapFilter.Color(m_Bitmap, dlg.red, dlg.green, dlg.blue))
                    this.Invalidate();
            }
        }

        private void TuyChinh_Click(object sender, EventArgs e)
        {
            Zoom x = new Zoom();
            x.sz = 0;
            if(DialogResult.OK == x.ShowDialog())
            {
                Zoom = x.sz/100;
                this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
                this.Invalidate();

            }
        }
    }
}
