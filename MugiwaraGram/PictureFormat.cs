using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MugiwaraGram
{
    internal class PictureFormat : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe) 
        {
            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            obj.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region rg = new Region(obj);
            this.Region = rg;
            base.OnPaint(pe);
        }
    }
}
