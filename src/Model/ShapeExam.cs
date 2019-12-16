using System;
using System.Drawing;

namespace Draw
{
    [Serializable]
    class ShapeExam : Shape
    {
        #region Constructor

        public ShapeExam() : base()
        { }

        public ShapeExam(RectangleF rect) : base(rect)
        {
        }

        public ShapeExam(ShapeExam examShape) : base(examShape)
        {
        }

        #endregion

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            // cast-ваме x и y от froat към int
            int x = int.Parse(Rectangle.X.ToString());
            int y = int.Parse(Rectangle.Y.ToString());

            Point[] points = {
                new Point(x, y),
                new Point(x + (int)Rectangle.Width, y + (int)Rectangle.Height/2),
                new Point(x + (int)Rectangle.Width, y + (int)Rectangle.Height),
                new Point(x + (int)Rectangle.Width, y + (int)Rectangle.Height/2),
                new Point(x + (int)Rectangle.Width*2, y ),
                new Point(x + (int)Rectangle.Width, y + (int)Rectangle.Height/2)
            };

            grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width*2, Rectangle.Height);
            grfx.DrawRectangle(new Pen(BorderColor, BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width*2, Rectangle.Height);

            grfx.FillPolygon(new SolidBrush(FillColor), points);
            grfx.DrawPolygon(new Pen(BorderColor, BorderWidth), points);
        }
    }
}

