namespace Graphic_Editor
{
    partial class FormShapes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DUDWidth = new System.Windows.Forms.DomainUpDown();
            this.DUDHeight = new System.Windows.Forms.DomainUpDown();
            this.BtnColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DUDX = new System.Windows.Forms.DomainUpDown();
            this.DUDY = new System.Windows.Forms.DomainUpDown();
            this.CBListShapes = new System.Windows.Forms.ComboBox();
            this.BtnRun = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DUDWidth);
            this.groupBox1.Controls.Add(this.DUDHeight);
            this.groupBox1.Controls.Add(this.BtnColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DUDX);
            this.groupBox1.Controls.Add(this.DUDY);
            this.groupBox1.Controls.Add(this.CBListShapes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Width : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Height : ";
            // 
            // DUDWidth
            // 
            this.DUDWidth.Location = new System.Drawing.Point(209, 159);
            this.DUDWidth.Name = "DUDWidth";
            this.DUDWidth.Size = new System.Drawing.Size(120, 23);
            this.DUDWidth.TabIndex = 9;
            // 
            // DUDHeight
            // 
            this.DUDHeight.Location = new System.Drawing.Point(209, 185);
            this.DUDHeight.Name = "DUDHeight";
            this.DUDHeight.Size = new System.Drawing.Size(120, 23);
            this.DUDHeight.TabIndex = 8;
            // 
            // BtnColor
            // 
            this.BtnColor.BackColor = System.Drawing.Color.DarkRed;
            this.BtnColor.Location = new System.Drawing.Point(30, 223);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(298, 30);
            this.BtnColor.TabIndex = 7;
            this.BtnColor.UseVisualStyleBackColor = false;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "X : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type shapes : ";
            // 
            // DUDX
            // 
            this.DUDX.Location = new System.Drawing.Point(209, 80);
            this.DUDX.Name = "DUDX";
            this.DUDX.Size = new System.Drawing.Size(120, 23);
            this.DUDX.TabIndex = 3;
            // 
            // DUDY
            // 
            this.DUDY.Location = new System.Drawing.Point(209, 106);
            this.DUDY.Name = "DUDY";
            this.DUDY.Size = new System.Drawing.Size(120, 23);
            this.DUDY.TabIndex = 2;
            // 
            // CBListShapes
            // 
            this.CBListShapes.FormattingEnabled = true;
            this.CBListShapes.Location = new System.Drawing.Point(208, 36);
            this.CBListShapes.Name = "CBListShapes";
            this.CBListShapes.Size = new System.Drawing.Size(121, 24);
            this.CBListShapes.TabIndex = 1;
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(198, 301);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(85, 28);
            this.BtnRun.TabIndex = 1;
            this.BtnRun.Text = "Shape";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(99, 301);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(85, 28);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FormShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(386, 341);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormShapes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShapes";
            this.Load += new System.EventHandler(this.FormShapes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown DUDX;
        private System.Windows.Forms.DomainUpDown DUDY;
        private System.Windows.Forms.ComboBox CBListShapes;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown DUDWidth;
        private System.Windows.Forms.DomainUpDown DUDHeight;
    }
}