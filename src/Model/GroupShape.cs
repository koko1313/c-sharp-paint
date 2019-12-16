using System;
using System.Collections.Generic;
using System.Drawing;

namespace Draw
{
    /// <summary>
    /// Класът ... е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    [Serializable]
    public class GroupShape : Shape
    {
        public static int groupNumber = 0; // статична променлива за номера на групата

        #region Constructor

        public GroupShape() : base()
        { }

        public GroupShape(RectangleF rect) : base(rect)
        {
            groupIndex = groupNumber;
            groupNumber++;
        }

        public GroupShape(RectangleShape rectangle) : base(rectangle)
        {
            groupIndex = groupNumber;
            groupNumber++;
        }

        #endregion   

        public static Dictionary<int, List<Shape>> groupFigures = new Dictionary<int, List<Shape>>();

        private int groupIndex;
        public int GroupIndex {
            get { return groupIndex; }
            set { groupIndex = value; }
        }

        private List<Shape> subItems = new List<Shape>(); // property, списък с поделементи на групата
        public List<Shape> SubItems {
            get { return subItems; }
            set { subItems = value; }
        }

        /// <summary>
        /// Проверка за принадлежност на точка point към правоъгълника.
        /// В случая на правоъгълник този метод може да не бъде пренаписван, защото
        /// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
        /// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
        /// елемента в този случай).
        /// </summary>
        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                foreach (var item in subItems)
                    if (item.Contains(point)) return true;
                return true;
            }
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            foreach (var item in subItems)
                item.DrawSelf(grfx);

        }

        public override void Move(float dx, float dy) {
            base.Move(dx, dy);
            foreach (var item in SubItems)
                item.Move(dx, dy);
        }

        public override Color FillColor
        {
            set {
                foreach (var item in SubItems)
                    item.FillColor = value;
            }
        }

        public override void ChangeSize(int size){
            return;
        }
        
    }
}
