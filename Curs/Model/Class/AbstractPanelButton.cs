using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.Model.Class
{
    public abstract class AbstractPanelButton : Button
    {
        public DateTime lastClickTime { get; set; }
        //точка перемещения
        Point DownPoint;
        //нажата ли кнопка мыши
        private bool IsDragMode;
        private bool isResizing;
        public MouseEventHandler delete {  get; set; }  
        public AbstractPanelButton(string FromFile)
        {
            Size = new Size(50, 50);
            if (!Distribution.DistributionImage(FromFile))
            {
                BackgroundImageLayout = ImageLayout.Stretch;
                BackgroundImage = Image.FromFile(FromFile);
            }else
                Text = "Нажми на меня два раза!";
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (e.Location.X > Width - 10 && e.Location.Y > Height - 10)
                {
                    isResizing = true;
                }
                else
                {
                    DownPoint = e.Location;
                    IsDragMode = true;
                    base.OnMouseDown(e);
                }
            }
            else
            {
                delete?.Invoke(this, e);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            IsDragMode = false;
            isResizing = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (isResizing)
            {
                int newWidth = Math.Max(e.X, 50);
                int newHeight = Math.Max(e.Y, 50);
                Size = new Size(newWidth, newHeight);
            }
            else if (IsDragMode)
            {
                Point p = e.Location;
                //вычисляем разницу в координатах между положением курсора и "нулевой" точкой кнопки
                Point dp = new Point(p.X - DownPoint.X, p.Y - DownPoint.Y);
                Location = new Point(Location.X + dp.X, Location.Y + dp.Y);
            }
            base.OnMouseMove(e);
        }
    }
}
