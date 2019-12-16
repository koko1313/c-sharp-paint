using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    /// <summary>
    /// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    [Serializable]
    public class EllipseShape : Shape
    {
        #region Constructor

        public EllipseShape() : base()
        {}

        public EllipseShape(RectangleF rect) : base(rect)
        {
        }

        public EllipseShape(RectangleShape rectangle) : base(rectangle)
        {
        }

        #endregion

        /// <summary>
        /// Проверка за принадлежност на точка point към елипсата.
        /// </summary>
        public override bool Contains(PointF point)
        {
            if (base.Contains(point)){
                // Проверка дали е в обекта само, ако точката е в него.
                float a = Width / 2 + BorderWidth / 2;
                float b = Height / 2 + BorderWidth / 2;
                float x0 = Location.X + a - BorderWidth / 2;
                float y0 = Location.Y + b - BorderWidth / 2;

                return Math.Pow((point.X - x0) / a, 2) + Math.Pow((point.Y - y0) / b, 2) - 1 <= 0;
            }
            else{
                // Ако не е, то неможе да е в обекта и => false
                return false;
            }
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(new Pen(BorderColor, BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
        }
    }
}
