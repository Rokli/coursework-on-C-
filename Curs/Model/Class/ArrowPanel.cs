using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.Model.Class
{
    public class ArrowPanel : AbstractPanelButton
    {
        public int RotateAngle { get; set; }
        public ArrowPanel(string FromFile) : base(FromFile)
        {
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            int delta = e.Delta;

            // Поворот кнопки на значение delta
            RotateAngle += delta/4;

            // Обновление визуального представления кнопки
            Invalidate();

            base.OnMouseWheel(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Создайте экземпляр графики из контекста
            Graphics graphics = e.Graphics;

            // Поверните графику вокруг центра кнопки
            graphics.TranslateTransform(Width / 2, Height / 2);
            graphics.RotateTransform(RotateAngle);
            graphics.TranslateTransform(-Width / 2, -Height / 2);

            // Вызов базовой реализации
            base.OnPaint(e);
        }
    }
}
