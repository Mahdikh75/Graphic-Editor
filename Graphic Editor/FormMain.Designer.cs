namespace Graphic_Editor
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerDIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screenShotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addImgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WriteToImg = new System.Windows.Forms.ToolStripTextBox();
            this.StatusInFo = new System.Windows.Forms.StatusStrip();
            this.InfoPic = new System.Windows.Forms.ToolStripStatusLabel();
            this.InfoImgP = new System.Windows.Forms.ToolStripStatusLabel();
            this.InfoImg = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripMXZ = new System.Windows.Forms.ToolStrip();
            this.ToolSpPen = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonEraser = new System.Windows.Forms.ToolStripButton();
            this.ToolSpText = new System.Windows.Forms.ToolStripButton();
            this.ToolSpColor = new System.Windows.Forms.ToolStripButton();
            this.ToolSpColorBS = new System.Windows.Forms.ToolStripButton();
            this.ToolSpSmColor = new System.Windows.Forms.ToolStripButton();
            this.ToolSpPointer = new System.Windows.Forms.ToolStripButton();
            this.PictureBoxMain = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuStripMain.SuspendLayout();
            this.StatusInFo.SuspendLayout();
            this.ToolStripMXZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.BackColor = System.Drawing.Color.DodgerBlue;
            this.MenuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.WriteToImg});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStripMain.Size = new System.Drawing.Size(792, 31);
            this.MenuStripMain.TabIndex = 0;
            this.MenuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.createToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.claerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::Graphic_Editor.Properties.Resources.image;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Image = global::Graphic_Editor.Properties.Resources.image__2_;
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // claerToolStripMenuItem
            // 
            this.claerToolStripMenuItem.Image = global::Graphic_Editor.Properties.Resources.image__1_;
            this.claerToolStripMenuItem.Name = "claerToolStripMenuItem";
            this.claerToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.claerToolStripMenuItem.Text = "Claer ";
            this.claerToolStripMenuItem.Click += new System.EventHandler(this.claerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesPictureToolStripMenuItem,
            this.managerDIRToolStripMenuItem,
            this.autoSizeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // propertiesPictureToolStripMenuItem
            // 
            this.propertiesPictureToolStripMenuItem.Name = "propertiesPictureToolStripMenuItem";
            this.propertiesPictureToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.propertiesPictureToolStripMenuItem.Text = "Properties picture";
            this.propertiesPictureToolStripMenuItem.Click += new System.EventHandler(this.propertiesPictureToolStripMenuItem_Click);
            // 
            // managerDIRToolStripMenuItem
            // 
            this.managerDIRToolStripMenuItem.Name = "managerDIRToolStripMenuItem";
            this.managerDIRToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.managerDIRToolStripMenuItem.Text = "Manager DIR";
            this.managerDIRToolStripMenuItem.Click += new System.EventHandler(this.managerDIRToolStripMenuItem_Click);
            // 
            // autoSizeToolStripMenuItem
            // 
            this.autoSizeToolStripMenuItem.Name = "autoSizeToolStripMenuItem";
            this.autoSizeToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.autoSizeToolStripMenuItem.Text = "Auto Size Img";
            this.autoSizeToolStripMenuItem.Click += new System.EventHandler(this.autoSizeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.corpToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 27);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.resizeToolStripMenuItem.Text = "Resize";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.rotateToolStripMenuItem.Text = "Rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // corpToolStripMenuItem
            // 
            this.corpToolStripMenuItem.Name = "corpToolStripMenuItem";
            this.corpToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.corpToolStripMenuItem.Text = "Corp";
            this.corpToolStripMenuItem.Click += new System.EventHandler(this.corpToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.screenShotToolStripMenuItem,
            this.addImgToolStripMenuItem,
            this.whiteBlackToolStripMenuItem,
            this.shapesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 27);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // screenShotToolStripMenuItem
            // 
            this.screenShotToolStripMenuItem.Name = "screenShotToolStripMenuItem";
            this.screenShotToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.screenShotToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.screenShotToolStripMenuItem.Text = "Screen Shot";
            this.screenShotToolStripMenuItem.Click += new System.EventHandler(this.screenShotToolStripMenuItem_Click);
            // 
            // addImgToolStripMenuItem
            // 
            this.addImgToolStripMenuItem.Name = "addImgToolStripMenuItem";
            this.addImgToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.addImgToolStripMenuItem.Text = "Add Img";
            this.addImgToolStripMenuItem.Click += new System.EventHandler(this.addImgToolStripMenuItem_Click);
            // 
            // whiteBlackToolStripMenuItem
            // 
            this.whiteBlackToolStripMenuItem.Name = "whiteBlackToolStripMenuItem";
            this.whiteBlackToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.whiteBlackToolStripMenuItem.Text = "White | Black";
            this.whiteBlackToolStripMenuItem.Click += new System.EventHandler(this.whiteBlackToolStripMenuItem_Click);
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.shapesToolStripMenuItem.Text = "Shapes";
            this.shapesToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.aboutMeToolStripMenuItem.Text = "About me";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // WriteToImg
            // 
            this.WriteToImg.Name = "WriteToImg";
            this.WriteToImg.Size = new System.Drawing.Size(132, 27);
            this.WriteToImg.Text = "Text to image";
            // 
            // StatusInFo
            // 
            this.StatusInFo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusInFo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusInFo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoPic,
            this.InfoImgP});
            this.StatusInFo.Location = new System.Drawing.Point(0, 665);
            this.StatusInFo.Name = "StatusInFo";
            this.StatusInFo.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusInFo.Size = new System.Drawing.Size(792, 25);
            this.StatusInFo.TabIndex = 5;
            // 
            // InfoPic
            // 
            this.InfoPic.Name = "InfoPic";
            this.InfoPic.Size = new System.Drawing.Size(0, 20);
            // 
            // InfoImgP
            // 
            this.InfoImgP.ForeColor = System.Drawing.Color.White;
            this.InfoImgP.Name = "InfoImgP";
            this.InfoImgP.Size = new System.Drawing.Size(78, 20);
            this.InfoImgP.Text = "Panel Info ";
            // 
            // InfoImg
            // 
            this.InfoImg.Name = "InfoImg";
            this.InfoImg.Size = new System.Drawing.Size(0, 17);
            // 
            // ToolStripMXZ
            // 
            this.ToolStripMXZ.AutoSize = false;
            this.ToolStripMXZ.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ToolStripMXZ.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolStripMXZ.GripMargin = new System.Windows.Forms.Padding(5);
            this.ToolStripMXZ.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStripMXZ.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ToolStripMXZ.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSpPen,
            this.ToolStripButtonEraser,
            this.ToolSpText,
            this.ToolSpColor,
            this.ToolSpColorBS,
            this.ToolSpSmColor,
            this.ToolSpPointer});
            this.ToolStripMXZ.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.ToolStripMXZ.Location = new System.Drawing.Point(0, 31);
            this.ToolStripMXZ.Name = "ToolStripMXZ";
            this.ToolStripMXZ.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStripMXZ.Size = new System.Drawing.Size(43, 634);
            this.ToolStripMXZ.TabIndex = 8;
            this.ToolStripMXZ.Text = "toolStrip1";
            // 
            // ToolSpPen
            // 
            this.ToolSpPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSpPen.Image = global::Graphic_Editor.Properties.Resources.pencil;
            this.ToolSpPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSpPen.Name = "ToolSpPen";
            this.ToolSpPen.Size = new System.Drawing.Size(28, 28);
            this.ToolSpPen.Text = "ToolSpPen";
            this.ToolSpPen.ToolTipText = "مداد";
            this.ToolSpPen.Click += new System.EventHandler(this.ToolSpPen_Click);
            // 
            // ToolStripButtonEraser
            // 
            this.ToolStripButtonEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonEraser.Image = global::Graphic_Editor.Properties.Resources.eraser;
            this.ToolStripButtonEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonEraser.Name = "ToolStripButtonEraser";
            this.ToolStripButtonEraser.Size = new System.Drawing.Size(28, 28);
            this.ToolStripButtonEraser.Text = "Eraser";
            this.ToolStripButtonEraser.Click += new System.EventHandler(this.ToolStripButtonEraser_Click);
            // 
            // ToolSpText
            // 
            this.ToolSpText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSpText.Image = global::Graphic_Editor.Properties.Resources.font;
            this.ToolSpText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSpText.Name = "ToolSpText";
            this.ToolSpText.Size = new System.Drawing.Size(28, 28);
            this.ToolSpText.Text = "ToolSpText";
            this.ToolSpText.ToolTipText = "متن";
            this.ToolSpText.Click += new System.EventHandler(this.ToolSpText_Click);
            // 
            // ToolSpColor
            // 
            this.ToolSpColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSpColor.Image = global::Graphic_Editor.Properties.Resources.palette;
            this.ToolSpColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSpColor.Name = "ToolSpColor";
            this.ToolSpColor.Size = new System.Drawing.Size(28, 28);
            this.ToolSpColor.Text = "ToolSpColor";
            this.ToolSpColor.ToolTipText = "جعبه رنگ آمیزی";
            this.ToolSpColor.Click += new System.EventHandler(this.ToolSpColor_Click);
            // 
            // ToolSpColorBS
            // 
            this.ToolSpColorBS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSpColorBS.Image = global::Graphic_Editor.Properties.Resources.bucket_1;
            this.ToolSpColorBS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSpColorBS.Name = "ToolSpColorBS";
            this.ToolSpColorBS.Size = new System.Drawing.Size(28, 28);
            this.ToolSpColorBS.Text = "ToolSpColorBS";
            this.ToolSpColorBS.ToolTipText = "سطل رنگ";
            this.ToolSpColorBS.Click += new System.EventHandler(this.ToolSpColorBS_Click);
            // 
            // ToolSpSmColor
            // 
            this.ToolSpSmColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSpSmColor.Image = global::Graphic_Editor.Properties.Resources.Color_sampler_tool;
            this.ToolSpSmColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSpSmColor.Name = "ToolSpSmColor";
            this.ToolSpSmColor.Size = new System.Drawing.Size(28, 28);
            this.ToolSpSmColor.Text = "ToolSpSmColor";
            this.ToolSpSmColor.ToolTipText = "رنگ شناس";
            this.ToolSpSmColor.Click += new System.EventHandler(this.ToolSpSmColor_Click);
            // 
            // ToolSpPointer
            // 
            this.ToolSpPointer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSpPointer.Image = global::Graphic_Editor.Properties.Resources.cursor;
            this.ToolSpPointer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSpPointer.Name = "ToolSpPointer";
            this.ToolSpPointer.Size = new System.Drawing.Size(28, 28);
            this.ToolSpPointer.Text = "اشاره گر";
            this.ToolSpPointer.Click += new System.EventHandler(this.ToolSpPointer_Click_1);
            // 
            // PictureBoxMain
            // 
            this.PictureBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxMain.Image = global::Graphic_Editor.Properties.Resources.picture77;
            this.PictureBoxMain.Location = new System.Drawing.Point(43, 31);
            this.PictureBoxMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBoxMain.Name = "PictureBoxMain";
            this.PictureBoxMain.Size = new System.Drawing.Size(749, 634);
            this.PictureBoxMain.TabIndex = 9;
            this.PictureBoxMain.TabStop = false;
            this.PictureBoxMain.Click += new System.EventHandler(this.PictureBoxMain_Click);
            this.PictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMain_MouseDown);
            this.PictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMain_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 690);
            this.Controls.Add(this.PictureBoxMain);
            this.Controls.Add(this.ToolStripMXZ);
            this.Controls.Add(this.StatusInFo);
            this.Controls.Add(this.MenuStripMain);
            this.MainMenuStrip = this.MenuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.StatusInFo.ResumeLayout(false);
            this.StatusInFo.PerformLayout();
            this.ToolStripMXZ.ResumeLayout(false);
            this.ToolStripMXZ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem claerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem screenShotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addImgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteBlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusInFo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel InfoImg;
        private System.Windows.Forms.ToolStripStatusLabel InfoPic;
        private System.Windows.Forms.ToolStrip ToolStripMXZ;
        private System.Windows.Forms.ToolStripButton ToolSpPen;
        private System.Windows.Forms.ToolStripButton ToolSpColor;
        private System.Windows.Forms.ToolStripButton ToolSpColorBS;
        private System.Windows.Forms.ToolStripButton ToolSpSmColor;
        public System.Windows.Forms.PictureBox PictureBoxMain;
        private System.Windows.Forms.ToolStripMenuItem managerDIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ToolStripButtonEraser;
        private System.Windows.Forms.ToolStripStatusLabel InfoImgP;
        private System.Windows.Forms.ToolStripMenuItem autoSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ToolSpText;
        private System.Windows.Forms.ToolStripButton ToolSpPointer;
        private System.Windows.Forms.ToolStripTextBox WriteToImg;
    }
}

