using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Draw
{
    /// <summary>
    /// Класът, който ще бъде използван при управляване на диалога.
    /// </summary>
    public class DialogProcessor : DisplayProcessor
    {
        #region Constructor

        public DialogProcessor()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Избран елемент.
        /// </summary>
        private List<Shape> selection = new List<Shape>();
        public List<Shape> Selection
        {
            get { return selection; }
            set { selection = value; }
        }

        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>
        private bool isDragging;
        public bool IsDragging {
            get { return isDragging; }
            set { isDragging = value; }
        }

        /// <summary>
        /// Последна позиция на мишката при "влачене".
        /// Използва се за определяне на вектора на транслация.
        /// </summary>
        private PointF lastLocation;
        public PointF LastLocation {
            get { return lastLocation; }
            set { lastLocation = value; }
        }

        private bool isMoved;
        public bool IsMoved {
            get { return isMoved; }
            set { isMoved = value; }
        }

        private bool wasSelected;
        public bool WasSelected {
            get { return wasSelected; }
            set { wasSelected = value; }
        }
        #endregion

        /// <summary>
        /// Добавя примитив - правоъгълник на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomRectangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200));
            rect.FillColor = Color.White;

            ShapeList.Add(rect);
        }

        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point)
        {
            for (int i = ShapeList.Count - 1; i >= 0; i--) {
                if (ShapeList[i].Contains(point)) {
                    //ShapeList[i].FillColor = Color.Red;

                    return ShapeList[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
        /// </summary>
        /// <param name="p">Вектор на транслация.</param>
        public void TranslateTo(PointF p)
        {
            foreach (var item in Selection) {
                item.Move(p.X - lastLocation.X, p.Y - lastLocation.Y);
            }
            lastLocation = p;
        }


        // ###################################################################################### \\

        #region Добавяне на примитиви (фигури)

        /// <summary>
        /// Добавя примитив - елипса на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomEllipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 200));
            ellipse.FillColor = Color.White;
            ellipse.BorderColor = Color.Black;

            ShapeList.Add(ellipse);
        }

        /// <summary>
        /// Добавя примитив - кръг на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomCircle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 100));
            CircleShape circle = new CircleShape(new Rectangle(x, y, 100, 100));

            circle.FillColor = Color.White;

            ShapeList.Add(circle);
        }

        /// <summary>
        /// Добавя примитив - триъгълник на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomTriangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 100));
            TriangleShape triangle = new TriangleShape(new Rectangle(x, y, 100, 100));

            triangle.FillColor = Color.White;

            ShapeList.Add(triangle);
        }

        public void AddRandomShapeExam() {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 100));
            ShapeExam triangle = new ShapeExam(new Rectangle(x, y, 100, 100));

            triangle.FillColor = Color.White;

            ShapeList.Add(triangle);
        }

        #endregion

        /// <summary>
        /// Сетване на запълващ цвят за последно селектирана фигура
        /// </summary>
        /// <param name="color"></param>
        public void SetSelectedFillColor(Color color) {
            foreach (var item in Selection) {
                item.FillColor = color;
            }
        }

        /// <summary>
        /// Сетване на цвят на граница за последно селектирана фигура
        /// </summary>
        /// <param name="color"></param>
        public void SetSelectedBorderColor(Color color) {
            foreach (var item in Selection) {
                item.BorderColor = color;
            }
        }

        public override void Draw(Graphics grfx) {
            base.Draw(grfx);

            foreach (var item in Selection) {
                float[] dashValues = { 5, 2 };
                Pen dashedPen = new Pen(Color.Gray, 1);
                dashedPen.DashPattern = dashValues;

                // За да се завърти и селекцията
                Matrix m = new Matrix();
                m.RotateAt((float)item.Angle, new PointF(item.Location.X + (item.Width / 2), item.Location.Y + (item.Height / 2)));
                grfx.Transform = m;
                //grfx.ResetTransform(); // махаме това, когато работи горното оставяме долното :D

                grfx.DrawRectangle(dashedPen, item.Location.X - (3 + (item.BorderWidth / 2)), item.Location.Y - (3 + (item.BorderWidth / 2)), item.Width + (6 + item.BorderWidth), item.Height + (6 + item.BorderWidth)); // добавяме и малко разстояние  

                grfx.ResetTransform();
            }
        }

        public void GroupSelected() {
            if (Selection.Count < 2) return; // ако имаме по-малко от 2 елемента излизаме, няма нужда да правим обхващаща селекция само на един елемент

            float minX = float.PositiveInfinity; // в началото минимума е плюс безкрайност
            float minY = float.PositiveInfinity;
            float maxX = float.NegativeInfinity;
            float maxY = float.NegativeInfinity;
            foreach (var item in Selection) {
                if (minX > item.Location.X) minX = item.Location.X;
                if (minY > item.Location.Y) minY = item.Location.Y;
                if (maxX < item.Location.X + item.Width) maxX = item.Location.X + item.Width;
                if (maxY < item.Location.Y + item.Height) maxY = item.Location.Y + item.Height;
            }

            var group = new GroupShape(new RectangleF(minX, minY, maxX - minX, maxY - minY)); // съставяме групата


            group.SubItems = Selection;

            List<Shape> ListOfGroupedShapes = new List<Shape>();
            GroupShape.groupFigures.Add(GroupShape.groupNumber, ListOfGroupedShapes);

            foreach (var item in Selection) {
                ListOfGroupedShapes.Add(item);
                ShapeList.Remove(item);
            }

            Selection = new List<Shape>();

            Selection.Add(group);
            ShapeList.Add(group);
        }

        public void UngroupSelected() {
            foreach (var select in Selection.ToArray()) { // преобразуваме към array за да можем да премахваме от Selection
                try {
                    GroupShape group = (GroupShape)select;
                    Selection.Remove(select);
                    ShapeList.Remove(select);

                    foreach (var item in group.SubItems)
                    {
                        Selection.Add(item);
                        ShapeList.Add(item);
                    }
                } catch {
                    continue;
                }
            }
        }

        public void BorderWidth(int width) {
            foreach (var item in Selection) {
                if(item.GetType() != typeof(GroupShape)) // ако селектираното не е група
                item.BorderWidth = width;
            }
        }

        public void IncreaseSize(int size) {
            foreach (var item in Selection) {
                item.ChangeSize(size);
            }
        }

        public void DecreaseSize(int size){
            foreach (var item in Selection) {
                item.ChangeSize(-size);
            }
        }

        public void DeleteSelected() {
            foreach (var item in Selection)
                ShapeList.Remove(item);
            Selection.Clear();
        }

        public void SaveAs(string fileName) {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(stream, ShapeList);
            stream.Close();
        }

        public void OpenFile(string fileName) {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open);
            ShapeList = (List<Shape>)formatter.Deserialize(stream);
            stream.Close();
        }

        public void SelectAll() {
            Selection = new List<Shape>(ShapeList);
        }

        public void DeselectAll() {
            Selection.Clear();
        }

        public void CopyToClipboard() {
            Clipboard.Clear();
            Clipboard.SetData("Selection", Selection);
        }

        public void PasteFromClipboard() {
            if (Clipboard.ContainsData("Selection")) {
                Selection.Clear();
                List<Shape> CopyList = (List<Shape>)Clipboard.GetData("Selection");
                foreach (var item in CopyList){
                    ShapeList.Add(item);
                    Selection.Add(item);
                }
            }
        }

        public void RotateSelected(double angle) {
            foreach (var item in Selection) {
                item.Angle = angle;
            }
        }
    }
}
