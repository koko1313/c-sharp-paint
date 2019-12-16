namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ungroupSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fillColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawElipseSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawCircleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawTriangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.setFillColorSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.setBorderColorSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.selectionGroupSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.selectionUngroupSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.increaseSizeSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.decreaseSizeSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.deleteSelectedSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.setFillColorDialog = new System.Windows.Forms.ColorDialog();
            this.setBorderWidthComboBox = new System.Windows.Forms.ComboBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rotationTtrackBar = new System.Windows.Forms.TrackBar();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationTtrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(693, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveToolStripMenuItem.Text = "Save As ...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.groupSelectedToolStripMenuItem,
            this.ungroupSelectedToolStripMenuItem,
            this.toolStripSeparator5,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.deselectAllToolStripMenuItem.Text = "Deselect all";
            this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // groupSelectedToolStripMenuItem
            // 
            this.groupSelectedToolStripMenuItem.Name = "groupSelectedToolStripMenuItem";
            this.groupSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.groupSelectedToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.groupSelectedToolStripMenuItem.Text = "Group selected";
            this.groupSelectedToolStripMenuItem.Click += new System.EventHandler(this.SelectionGroupSpeedButtonClick);
            // 
            // ungroupSelectedToolStripMenuItem
            // 
            this.ungroupSelectedToolStripMenuItem.Name = "ungroupSelectedToolStripMenuItem";
            this.ungroupSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.ungroupSelectedToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ungroupSelectedToolStripMenuItem.Text = "Ungroup selected";
            this.ungroupSelectedToolStripMenuItem.Click += new System.EventHandler(this.SelectionUngroupSpeedButtonClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(206, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.deleteToolStripMenuItem.Text = "Delete selected";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedSpeedButtonClick);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator6,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.triangleToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.newToolStripMenuItem.Text = "New ...";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.DrawElipseSpeedButtonClick);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.DrawCIrcleSpeedButtonClick);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.DrawTriangleSpeedButtonClick);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(141, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpToolStripMenuItem,
            this.toolStripSeparator4,
            this.fillColorToolStripMenuItem,
            this.borderColorToolStripMenuItem,
            this.toolStripSeparator3,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // pickUpToolStripMenuItem
            // 
            this.pickUpToolStripMenuItem.Name = "pickUpToolStripMenuItem";
            this.pickUpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.pickUpToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.pickUpToolStripMenuItem.Text = "Pick Up";
            this.pickUpToolStripMenuItem.Click += new System.EventHandler(this.pickUpCheckUncheck);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(219, 6);
            // 
            // fillColorToolStripMenuItem
            // 
            this.fillColorToolStripMenuItem.Name = "fillColorToolStripMenuItem";
            this.fillColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fillColorToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.fillColorToolStripMenuItem.Text = "Fill Color";
            this.fillColorToolStripMenuItem.Click += new System.EventHandler(this.SetFillColorSpeedButtonClick);
            // 
            // borderColorToolStripMenuItem
            // 
            this.borderColorToolStripMenuItem.Name = "borderColorToolStripMenuItem";
            this.borderColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.borderColorToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.borderColorToolStripMenuItem.Text = "Border Color";
            this.borderColorToolStripMenuItem.Click += new System.EventHandler(this.SetBorderColorSpeedButtonClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(219, 6);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.IncreaseSizeSpeedButtonClick);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.DecreaseSizeSpeedButtonClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 401);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(693, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedMenu
            // 
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawRectangleSpeedButton,
            this.drawElipseSpeedButton,
            this.drawCircleSpeedButton,
            this.drawTriangleSpeedButton,
            this.pickUpSpeedButton,
            this.setFillColorSpeedButton,
            this.setBorderColorSpeedButton,
            this.selectionGroupSpeedButton,
            this.selectionUngroupSpeedButton,
            this.increaseSizeSpeedButton,
            this.decreaseSizeSpeedButton,
            this.deleteSelectedSpeedButton,
            this.toolStripButton1});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(693, 25);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // drawElipseSpeedButton
            // 
            this.drawElipseSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawElipseSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawElipseSpeedButton.Image")));
            this.drawElipseSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawElipseSpeedButton.Name = "drawElipseSpeedButton";
            this.drawElipseSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.drawElipseSpeedButton.Text = "DrawElipseButton";
            this.drawElipseSpeedButton.ToolTipText = "DrawElipseButton";
            this.drawElipseSpeedButton.Click += new System.EventHandler(this.DrawElipseSpeedButtonClick);
            // 
            // drawCircleSpeedButton
            // 
            this.drawCircleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawCircleSpeedButton.Image")));
            this.drawCircleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircleSpeedButton.Name = "drawCircleSpeedButton";
            this.drawCircleSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.drawCircleSpeedButton.Text = "DrawCircleButton";
            this.drawCircleSpeedButton.Click += new System.EventHandler(this.DrawCIrcleSpeedButtonClick);
            // 
            // drawTriangleSpeedButton
            // 
            this.drawTriangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawTriangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawTriangleSpeedButton.Image")));
            this.drawTriangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawTriangleSpeedButton.Name = "drawTriangleSpeedButton";
            this.drawTriangleSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.drawTriangleSpeedButton.Text = "DrawTriangleButton";
            this.drawTriangleSpeedButton.Click += new System.EventHandler(this.DrawTriangleSpeedButtonClick);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.pickUpSpeedButton.Text = "PickUpButton";
            this.pickUpSpeedButton.ToolTipText = "PickUpButton";
            // 
            // setFillColorSpeedButton
            // 
            this.setFillColorSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setFillColorSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("setFillColorSpeedButton.Image")));
            this.setFillColorSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setFillColorSpeedButton.Name = "setFillColorSpeedButton";
            this.setFillColorSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.setFillColorSpeedButton.Text = "SetFillColorButton";
            this.setFillColorSpeedButton.Click += new System.EventHandler(this.SetFillColorSpeedButtonClick);
            // 
            // setBorderColorSpeedButton
            // 
            this.setBorderColorSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setBorderColorSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("setBorderColorSpeedButton.Image")));
            this.setBorderColorSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setBorderColorSpeedButton.Name = "setBorderColorSpeedButton";
            this.setBorderColorSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.setBorderColorSpeedButton.Text = "SetBorderColorButton";
            this.setBorderColorSpeedButton.ToolTipText = "SetBorderColorButton";
            this.setBorderColorSpeedButton.Click += new System.EventHandler(this.SetBorderColorSpeedButtonClick);
            // 
            // selectionGroupSpeedButton
            // 
            this.selectionGroupSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectionGroupSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("selectionGroupSpeedButton.Image")));
            this.selectionGroupSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectionGroupSpeedButton.Name = "selectionGroupSpeedButton";
            this.selectionGroupSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.selectionGroupSpeedButton.Text = "SelectionGroupButton";
            this.selectionGroupSpeedButton.Click += new System.EventHandler(this.SelectionGroupSpeedButtonClick);
            // 
            // selectionUngroupSpeedButton
            // 
            this.selectionUngroupSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectionUngroupSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("selectionUngroupSpeedButton.Image")));
            this.selectionUngroupSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectionUngroupSpeedButton.Name = "selectionUngroupSpeedButton";
            this.selectionUngroupSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.selectionUngroupSpeedButton.Text = "SelectionUngroupButton";
            this.selectionUngroupSpeedButton.Click += new System.EventHandler(this.SelectionUngroupSpeedButtonClick);
            // 
            // increaseSizeSpeedButton
            // 
            this.increaseSizeSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseSizeSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("increaseSizeSpeedButton.Image")));
            this.increaseSizeSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increaseSizeSpeedButton.Name = "increaseSizeSpeedButton";
            this.increaseSizeSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.increaseSizeSpeedButton.Text = "IncreaseSizeButton";
            this.increaseSizeSpeedButton.Click += new System.EventHandler(this.IncreaseSizeSpeedButtonClick);
            // 
            // decreaseSizeSpeedButton
            // 
            this.decreaseSizeSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseSizeSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("decreaseSizeSpeedButton.Image")));
            this.decreaseSizeSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseSizeSpeedButton.Name = "decreaseSizeSpeedButton";
            this.decreaseSizeSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.decreaseSizeSpeedButton.Text = "DecreaseSizeButton";
            this.decreaseSizeSpeedButton.Click += new System.EventHandler(this.DecreaseSizeSpeedButtonClick);
            // 
            // deleteSelectedSpeedButton
            // 
            this.deleteSelectedSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteSelectedSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteSelectedSpeedButton.Image")));
            this.deleteSelectedSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteSelectedSpeedButton.Name = "deleteSelectedSpeedButton";
            this.deleteSelectedSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.deleteSelectedSpeedButton.Text = "DeleteSelectedButton";
            this.deleteSelectedSpeedButton.Click += new System.EventHandler(this.DeleteSelectedSpeedButtonClick);
            // 
            // setBorderWidthComboBox
            // 
            this.setBorderWidthComboBox.FormattingEnabled = true;
            this.setBorderWidthComboBox.Items.AddRange(new object[] {
            "Thin",
            "Medium",
            "Thick"});
            this.setBorderWidthComboBox.Location = new System.Drawing.Point(506, 28);
            this.setBorderWidthComboBox.Name = "setBorderWidthComboBox";
            this.setBorderWidthComboBox.Size = new System.Drawing.Size(121, 21);
            this.setBorderWidthComboBox.TabIndex = 5;
            this.setBorderWidthComboBox.Text = "Border Width";
            this.setBorderWidthComboBox.SelectedIndexChanged += new System.EventHandler(this.SetBorderWidthComboBox_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // rotationTtrackBar
            // 
            this.rotationTtrackBar.Location = new System.Drawing.Point(354, 27);
            this.rotationTtrackBar.Maximum = 100;
            this.rotationTtrackBar.Name = "rotationTtrackBar";
            this.rotationTtrackBar.Size = new System.Drawing.Size(124, 45);
            this.rotationTtrackBar.TabIndex = 6;
            this.rotationTtrackBar.Scroll += new System.EventHandler(this.RotationTtrackBar_Scroll);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 49);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(693, 352);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 423);
            this.Controls.Add(this.rotationTtrackBar);
            this.Controls.Add(this.setBorderWidthComboBox);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationTtrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton drawElipseSpeedButton;
        private System.Windows.Forms.ToolStripButton drawCircleSpeedButton;
        private System.Windows.Forms.ToolStripButton drawTriangleSpeedButton;
        private System.Windows.Forms.ToolStripButton setFillColorSpeedButton;
        private System.Windows.Forms.ColorDialog setFillColorDialog;
        private System.Windows.Forms.ToolStripButton selectionGroupSpeedButton;
        private System.Windows.Forms.ToolStripButton selectionUngroupSpeedButton;
        private System.Windows.Forms.ToolStripButton setBorderColorSpeedButton;
        private System.Windows.Forms.ComboBox setBorderWidthComboBox;
        private System.Windows.Forms.ToolStripButton increaseSizeSpeedButton;
        private System.Windows.Forms.ToolStripButton decreaseSizeSpeedButton;
        private System.Windows.Forms.ToolStripButton deleteSelectedSpeedButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem groupSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ungroupSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.TrackBar rotationTtrackBar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
