using System;
using System.Drawing;

namespace Draw
{
    [Serializable]
    public class CircleShape : Shape
    {
        #region Constructor

        public CircleShape() : base()
        { }

        public CircleShape(RectangleF rect) : base(rect)
        {
        }

        public CircleShape(CircleShape circle) : base(circle)
        {
        }

        #endregion

        public override bool Contains(PointF point)
        {
            if (base.Contains(point)) {
                float a = Width / 2 + BorderWidth / 2;
                float b = Height / 2 + BorderWidth / 2;
                float x0 = Location.X + a - BorderWidth / 2;
                float y0 = Location.Y + b - BorderWidth / 2;

                return Math.Pow((point.X - x0), 2) + Math.Pow((point.Y - y0), 2) <= Math.Pow(a, 2);
            }
            else return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Width);
            grfx.DrawEllipse(new Pen(BorderColor, BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Width);

        }
    }
}
