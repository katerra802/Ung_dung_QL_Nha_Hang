using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_form.Draw
{
    public class DrawPanel
    {
        public void DrawLeft(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            int radius = 20; // Bán kính góc bo
            Rectangle bounds = new Rectangle(0, 0, pnl.Width, pnl.Height);

            // Tạo bo tròn cho góc trên bên trái
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90); // Góc trên trái
            path.AddLine(radius, 0, bounds.Width, 0); // Đường thẳng trên cùng
            path.AddLine(bounds.Width, 0, bounds.Width, bounds.Height); // Đường thẳng bên phải
            path.AddLine(bounds.Width, bounds.Height, 0, bounds.Height); // Đường thẳng dưới cùng
            path.AddLine(0, bounds.Height, 0, radius); // Đường thẳng bên trái dưới góc bo

            // Thiết lập vùng bo góc cho Panel
            pnl.Region = new Region(path);

            // Vẽ nền cho Panel
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillRegion(new SolidBrush(pnl.BackColor), pnl.Region);
        }

        public void DrawRight(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            int radius = 90; // Bán kính góc bo
            Rectangle bounds = new Rectangle(0, 0, pnl.Width, pnl.Height);

          

            // Đường thẳng bên trái
            path.AddLine(0, 0, bounds.Width - radius, 0); // Đường thẳng trên cùng đến góc phải
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90); // Góc trên phải
            path.AddLine(bounds.Width, radius, bounds.Width, bounds.Height); // Đường thẳng bên phải
            path.AddLine(bounds.Width, bounds.Height, 0, bounds.Height); // Đường thẳng dưới cùng
            path.AddLine(0, bounds.Height, 0, 0); // Đường thẳng bên trái

            // Thiết lập vùng bo góc cho Panel
            pnl.Region = new Region(path);

            // Vẽ nền cho Panel
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillRegion(new SolidBrush(pnl.BackColor), pnl.Region);
        }

    }
}
