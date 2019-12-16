using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    /// <summary>
    /// Базовия клас на примитивите, който съдържа общите характеристики на примитивите.
    /// </summary>
    [Serializable]
    public abstract class Shape
    {
        #region Constructors

        public Shape()
        {
        }

        public Shape(RectangleF rect)
        {
            rectangle = rect;
        }

        public Shape(Shape shape)
        {
            this.Height = shape.Height;
            this.Width = shape.Width;
            this.Location = shape.Location;
            this.rectangle = shape.rectangle;

            this.FillColor = shape.FillColor;
            this.BorderColor = shape.BorderColor;
            this.BorderWidth = shape.BorderWidth;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Обхващащ правоъгълник на елемента.
        /// </summary>
        private RectangleF rectangle;
        public virtual RectangleF Rectangle {
            get { return rectangle; }
            set { rectangle = value; }
        }

        /// <summary>
        /// Широчина на елемента.
        /// </summary>
        public virtual float Width {
            get { return Rectangle.Width; }
            set { rectangle.Width = value; }
        }

        /// <summary>
        /// Височина на елемента.
        /// </summary>
        public virtual float Height {
            get { return Rectangle.Height; }
            set { rectangle.Height = value; }
        }

        /// <summary>
        /// Горен ляв ъгъл на елемента.
        /// </summary>
        public virtual PointF Location {
            get { return Rectangle.Location; }
            set { rectangle.Location = value; }
        }

        /// <summary>
        /// Цвят на елемента.
        /// </summary>
        private Color fillColor;
        public virtual Color FillColor {
            get { return fillColor; }
            set { fillColor = value; }
        }

        /// <summary>
        /// Цвят на контура на елемента.
        /// </summary>
        private Color borderColor = Color.Black;
        public virtual Color BorderColor {
            get { return borderColor; }
            set { borderColor = value; }
        }

        /// <summary>
        /// Дебелина на контура на елемента
        /// </summary>
        private int borderWidth;
        public virtual int BorderWidth {
            get { return borderWidth; }
            set { borderWidth = value; }
        }

        private double angle;
        public virtual double Angle {
            get { return angle; }
            set { angle = value; }
        }
        #endregion


        /// <summary>
        /// Проверка дали точка point принадлежи на елемента.
        /// </summary>
        /// <param name="point">Точка</param>
        /// <returns>Връща true, ако точката принадлежи на елемента и
        /// false, ако не пренадлежи</returns>
        public virtual bool Contains(PointF point)
		{
            return Rectangle.Contains(point.X + borderWidth/2, point.Y + borderWidth/2);
		}
		
		/// <summary>
		/// Визуализира елемента.
		/// </summary>
		/// <param name="grfx">Къде да бъде визуализиран елемента.</param>
		public virtual void DrawSelf(Graphics grfx)
		{
            //shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
            Matrix m = new Matrix();
            m.RotateAt((float)this.Angle, new PointF(Rectangle.X + (Rectangle.Width / 2), Rectangle.Y + (Rectangle.Height / 2)));
            grfx.Transform = m;
        }

        public virtual void Move(float dx, float dy) {
            Location = new PointF(Location.X + dx, Location.Y + dy);
        }

        public virtual void ChangeSize(int size) {
            if (size < 0 && Width == 10) return; // ограничаваме най-малък размер 10
            Rectangle = new RectangleF(Location.X, Location.Y, Width + size, Height + size);
        }

    }
}
