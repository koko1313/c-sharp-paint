using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        #region MenuButtons

        /// <summary>
        /// Изход от програмата. Затваря главната форма, а с това и програмата.
        /// </summary>
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Клик на About от менюто
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Калоян Величков, 1501261021\nТрети курс, Информатика\nПроект по Компютърна Графика", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Клик на Save от менюто
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if(saveFileDialog.ShowDialog() == DialogResult.OK) {
                dialogProcessor.SaveAs(saveFileDialog.FileName);
            }
        }

        /// <summary>
        /// Клик Open от менюто
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                dialogProcessor.OpenFile(openFileDialog.FileName);
                viewPort.Invalidate();
            }
        }

        /// <summary>
        /// Клик Select all от менюто
        /// </summary>
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            dialogProcessor.SelectAll();
            viewPort.Invalidate();
        }

        /// <summary>
        /// Клик Deselect all от менюто
        /// </summary>
        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            dialogProcessor.DeselectAll();
            viewPort.Invalidate();
        }

        /// <summary>
        /// За бързия клавиш за Pick Up tool-а, пуска го и го спира
        /// </summary>
        private void pickUpCheckUncheck(object sender, EventArgs e) {
            if (pickUpSpeedButton.Checked) pickUpSpeedButton.Checked = false;
            else pickUpSpeedButton.Checked = true;
        }

        /// <summary>
        /// Клик Copy от менюто
        /// </summary>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.CopyToClipboard();
        }

        /// <summary>
        /// Клик Paste от менюто
        /// </summary>
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.PasteFromClipboard();
            viewPort.Invalidate();
        }

        /// <summary>
        /// Клик Cut от менюто
        /// </summary>
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.CopyToClipboard();
            dialogProcessor.DeleteSelected();
            viewPort.Invalidate();
        }

        #endregion

        /// <summary>
        /// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
        /// </summary>
        void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}
		
		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle();
			
			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
			
			viewPort.Invalidate();
		}

		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (pickUpSpeedButton.Checked) {
                var sel = dialogProcessor.ContainsPoint(e.Location);
                if (sel != null)
                {
                    statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                    dialogProcessor.IsMoved = false;
                    dialogProcessor.IsDragging = true;
                    dialogProcessor.LastLocation = e.Location;

                    // ако елемента не е селектиран и ако не сме натиснали CTRL
                    if (!(ModifierKeys == Keys.Control) && !dialogProcessor.Selection.Contains(sel) ) {
                        dialogProcessor.Selection = new List<Shape>(); // разселектираме всички селектирани до момента обекти
                    }

                    // Ако не е селектиран обекта го селектираме
                    if (!dialogProcessor.Selection.Contains(sel)) {
                        dialogProcessor.Selection.Add(sel);
                        dialogProcessor.WasSelected = false; // отбелязваме че не е бил селектиран
                    } else {
                        dialogProcessor.WasSelected = true; // иначе отбелязваме че е бил селектиран
                    }

                    viewPort.Invalidate();
                } 
            }
		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            if (dialogProcessor.IsDragging)
            {
                if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
                dialogProcessor.TranslateTo(e.Location);
                dialogProcessor.IsMoved = true;
                viewPort.Invalidate();
            }
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            if (pickUpSpeedButton.Checked)
            {
                var sel = dialogProcessor.ContainsPoint(e.Location);
                if (sel != null)
                {

                    // Ако не е натиснат CTRL и ако има повече от 1 селектирани обекти и не са преместени
                    if (!(ModifierKeys == Keys.Control) && dialogProcessor.Selection.Count > 1 && !dialogProcessor.IsMoved) {
                        dialogProcessor.Selection = new List<Shape>(); // разселектираме всички
                        dialogProcessor.Selection.Add(sel); // селектираме само текущия
                    } else 
                    if (dialogProcessor.Selection.Contains(sel)) { // Разселектираме ако е селектиран обекта и ако е бил селектиран и ако не е преместен
                        if (dialogProcessor.WasSelected && !dialogProcessor.IsMoved) dialogProcessor.Selection.Remove(sel);
                    }

                    statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                    dialogProcessor.LastLocation = e.Location;
                    viewPort.Invalidate();
                }
            }
            dialogProcessor.IsDragging = false;
        }

        // ###################################################################################### \\

        /// <summary>
		/// Бутон, който поставя на произволно място елипса със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
        void DrawElipseSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomEllipse();

            statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

            viewPort.Invalidate();
        }

        /// <summary>
		/// Бутон, който поставя на произволно място кръг със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
        private void DrawCIrcleSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomCircle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на кръг";

            viewPort.Invalidate();
        }

        /// <summary>
		/// Бутон, който поставя на произволно място триъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
        private void DrawTriangleSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomTriangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон, който оцветява запълващия цвят на селектираната фигура
        /// </summary>
        private void SetFillColorSpeedButtonClick(object sender, EventArgs e)
        {
            if (setFillColorDialog.ShowDialog() == DialogResult.OK) {
                dialogProcessor.SetSelectedFillColor(setFillColorDialog.Color);
                viewPort.Invalidate();
            }
        }

        /// <summary>
        /// Бутон, който оцветява границата на селектираната фигура
        /// </summary>
        private void SetBorderColorSpeedButtonClick(object sender, EventArgs e)
        {
            if (setFillColorDialog.ShowDialog() == DialogResult.OK)
            {
                dialogProcessor.SetSelectedBorderColor(setFillColorDialog.Color);
                viewPort.Invalidate();
            }
        }

        /// <summary>
        /// Бутон, който при няколко селектирани фигури ги групира
        /// </summary>
        private void SelectionGroupSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.GroupSelected();
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон, който при селектирана група, разгрупира обектите в нея
        /// </summary>
        private void SelectionUngroupSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.UngroupSelected();
            viewPort.Invalidate();
        }

        /// <summary>
        /// Падащо меню за избиране на дебелината на границата на селектираните обекти
        /// </summary>
        private void SetBorderWidthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (setBorderWidthComboBox.Text == "Thin"){
                dialogProcessor.BorderWidth(1);
            } else
            if (setBorderWidthComboBox.Text == "Medium") {
                dialogProcessor.BorderWidth(10);
            } else {
                dialogProcessor.BorderWidth(20);
            }
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон, който увеличава размера на селектираните обекти
        /// </summary>
        private void IncreaseSizeSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.IncreaseSize(10);
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон, който намалява размера на селектираните обекти
        /// </summary>
        private void DecreaseSizeSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.DecreaseSize(10);
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон, който изтрива селектираните обекти
        /// </summary>
        private void DeleteSelectedSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.DeleteSelected();
            viewPort.Invalidate();
        }

        private void RotationTtrackBar_Scroll(object sender, EventArgs e)
        {
            dialogProcessor.RotateSelected(rotationTtrackBar.Value * 3.6);
            viewPort.Invalidate();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomShapeExam();
            viewPort.Invalidate();
        }
    }
}
