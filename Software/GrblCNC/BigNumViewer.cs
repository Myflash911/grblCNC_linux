using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrblCNC
{
    public partial class BigNumViewer : UserControl
    {
        //Bitmap bgndBitmap;
        Color titleBgndColor = Color.FromArgb(64, 64, 120);
        Color titleColor = Color.FromArgb(200, 255, 200);
        double value = 0;
        string valueFormat = "0.000";
        string titleLetter = "A";
        float fontCentH;
        bool loaded = false;
        float shadowThickness = 2;
        Pen darkp, lightp, midp;
        public BigNumViewer()
        {
            ForeColor = Color.Green;
            BackColor = Color.Black;
            InitializeComponent();
            DoubleBuffered = true;
       }

        protected override void OnLoad(EventArgs e)
        {
            loaded = true;
            UpdateSizes();
            base.OnLoad(e);
        }

        public Color TitleBackColor
        {
            get { return titleBgndColor; }
            set
            {
                titleBgndColor = value;
                Invalidate();
            }
        }

        public Color TitleForeColor
        {
            get { return titleColor; }
            set
            {
                titleColor = value;
                Invalidate();
            }
        }

        public String TitleLetter
        {
            get { return titleLetter; }
            set
            {
                titleLetter = value;
                Invalidate();
            }
        }

        public String ValueFormat
        {
            get { return valueFormat; }
            set
            {
                valueFormat = value;
                Invalidate();
            }
        }

        public double Value
        {
            get { return value; }
            set
            {
                this.value = value;
                Invalidate();
            }
        }

        

        void UpdateSizes()
        {
            if (!loaded)
                return;
            Font = new Font("Arial", Height * 3 / 5);
            float ascent = Font.FontFamily.GetCellAscent(FontStyle.Regular);
            float ascentPixel = Font.Height * ascent / Font.FontFamily.GetEmHeight(FontStyle.Regular);
            fontCentH = (Height - ascentPixel) / 2;
            darkp = new Pen(Color.FromArgb(64, 0, 0, 0), shadowThickness);
            lightp = new Pen(Color.FromArgb(64, 255, 255, 255), shadowThickness);
            midp = new Pen(Color.FromArgb(64, 128, 128, 128), shadowThickness);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float rad = (Height / 3);
            float drad =  rad * 2;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(Parent.BackColor);
            Brush tbrush = new SolidBrush(titleBgndColor);
            Brush bbrush = new SolidBrush(BackColor);
            g.FillEllipse(tbrush, 0, 0, drad, drad);
            g.FillEllipse(tbrush, 0, Height - drad, drad, drad);
            g.FillEllipse(bbrush, Width - drad, 0, drad, drad);
            g.FillEllipse(bbrush, Width - drad, Height - drad, drad, drad);
            g.FillRectangle(tbrush, rad, 0, Height - rad, Height);
            g.FillRectangle(tbrush, 0, rad, rad, rad);
            g.FillRectangle(bbrush, Height, 0, Width - Height - rad, Height);
            g.FillRectangle(bbrush, Width - rad, rad, rad, rad);
            // draw shadow
            float sdrad = drad - shadowThickness;
            float st2 = shadowThickness / 2;
            g.DrawArc(darkp, st2, st2, sdrad, sdrad, 180, 90);
            g.DrawLine(darkp, rad, st2, Width - rad, st2);
            g.DrawLine(darkp, st2, rad, st2, Height - rad);
            g.DrawArc(lightp, Width - sdrad - st2, Height - sdrad - st2, sdrad, sdrad, 0, 90);
            g.DrawLine(lightp, rad, Height - st2, Width - rad, Height - st2);
            g.DrawLine(lightp, Width - st2, rad, Width - st2, Height - rad);
            g.DrawArc(midp, st2, Height - sdrad - st2, sdrad, sdrad, 90, 90);
            g.DrawArc(midp, Width - sdrad - st2, st2, sdrad, sdrad, 270, 90);

            string stval = value.ToString(valueFormat);
            SizeF stsize = g.MeasureString(stval, Font);
            Brush txtBrush = new SolidBrush(ForeColor);
            float gap = rad / 2;
            g.DrawString(stval, Font, txtBrush, Width  - stsize.Width, fontCentH);
            txtBrush = new SolidBrush(titleColor);
            stsize = g.MeasureString(titleLetter, Font);
            g.DrawString(titleLetter, Font, txtBrush, gap + (Height - stsize.Width - gap) / 2, fontCentH);
            base.OnPaint(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            UpdateSizes();
            //Invalidate();
            base.OnSizeChanged(e);
        }
    }
}
