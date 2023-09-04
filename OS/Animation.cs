using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OS
{
    public class Rectangle : FIFO
    {
        public int x;
        public int y;
        public int side;
        public SolidBrush brush;
        int dx;
        int dy;

        public void rectanglee(int rch)
        {
            Random random = new Random(rch);
            side = 35;
            brush = new SolidBrush(RandomColor(rch));
            x = random.Next(1, ClientRectangle.Width - side);
            y = random.Next(1, ClientRectangle.Height - side);
            dx = 6;
            dy = 5;
        }


        public void Next()
        {
            if (x != FIFO.ActiveForm.Width - side)
                x += dx;
            if (y != FIFO.ActiveForm.Width - side)
                y += dy;
        }

        public Color RandomColor(int rch)
        {
            int r, g, b;
            byte[] bytes1 = new byte[3];
            Random rand = new Random(rch);
            rand.NextBytes(bytes1);

            r = Convert.ToInt16(bytes1[0]);
            g = Convert.ToInt16(bytes1[1]);
            b = Convert.ToInt16(bytes1[2]);
            return Color.FromArgb(r, g, b);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Name = "Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}