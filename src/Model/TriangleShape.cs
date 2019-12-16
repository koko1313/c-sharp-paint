using System;
using System.Drawing;

namespace Draw
{
    [Serializable]
    class TriangleShape : Shape
    {
        #region Constructor

        public TriangleShape() : base()
        { }

        public TriangleShape(RectangleF rect) : base(rect)
        {
        }

        public TriangleShape(TriangleShape triangle) : base(triangle)
        {
        }

        #endregion
        
        public override bool Contains(PointF point)
        {
            if (base.Contains(point)) {
                Point p1 = new Point((int)Rectangle.X - BorderWidth, (int)Rectangle.Y - BorderWidth/2);
                Point p2 = new Point((int)Rectangle.X + (int)Rectangle.Width + BorderWidth, (int)Rectangle.Y - BorderWidth/2);
                Point p3 = new Point((int)Rectangle.X + (int)Rectangle.Width/2, (int)Rectangle.Y + (int)Rectangle.Width + BorderWidth);
                PointF p = point;

                float alpha = ((p2.Y - p3.Y) * (p.X - p3.X) + (p3.X - p2.X) * (p.Y - p3.Y)) / ((p2.Y - p3.Y) * (p1.X - p3.X) + (p3.X - p2.X) * (p1.Y - p3.Y));
                float beta = ((p3.Y - p1.Y) * (p.X - p3.X) + (p1.X - p3.X) * (p.Y - p3.Y)) / ((p2.Y - p3.Y) * (p1.X - p3.X) + (p3.X - p2.X) * (p1.Y - p3.Y));
                float gamma = 1.0f - alpha - beta;

                return alpha > 0 && beta > 0 && gamma > 0;
            }
            else{
                return false;
            }
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            // cast-ваме x и y от froat към int
            int x = int.Parse(Rectangle.X.ToString());
            int y = int.Parse(Rectangle.Y.ToString());

            Point[] points = { new Point(x, y), new Point(x + (int)Rectangle.Width, y), new Point(x + (int)Rectangle.Width/2, y + (int)Rectangle.Width) };
            grfx.FillPolygon(new SolidBrush(FillColor), points);
            grfx.DrawPolygon(new Pen(BorderColor, BorderWidth), points);
        }
    }
}
