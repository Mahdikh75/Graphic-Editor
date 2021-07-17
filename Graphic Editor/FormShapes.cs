using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Editor
{
    public partial class FormShapes : Form
    {
        Color color = Color.DarkRed;

        public FormShapes()
        {
            InitializeComponent();
        }

        private void FormShapes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2000; i++)
            {
                DUDX.Items.Add(i);
                DUDY.Items.Add(i);
            }
            string[] itemLS = new string[] { "Square", "Rectangle", "Line", "Circle", "Oval" };
            CBListShapes.Items.AddRange(itemLS);

        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            Image img = (Image)this.Tag;
            Bitmap bmp = new Bitmap(img);
            Graphics graphic = Graphics.FromImage(bmp);
            SolidBrush Colorbsh = new SolidBrush(color);
            FormMain frm = new FormMain();

            switch (CBListShapes.Text)
            {
                case "Square":
                    graphic.FillRectangle(Colorbsh, new RectangleF(int.Parse(DUDX.Text), int.Parse(DUDY.Text), int.Parse(DUDWidth.Text), int.Parse(DUDHeight.Text)));
                    graphic.Save();
                    frm.Tag = bmp;
                    frm.Show();
                    Hide();
                    break;
                case "Rectangle":
                    graphic.FillRectangle(Colorbsh, new RectangleF(int.Parse(DUDX.Text), int.Parse(DUDY.Text), int.Parse(DUDWidth.Text), int.Parse(DUDHeight.Text)));
                    graphic.Save();
                    frm.Tag = bmp;
                    frm.Show();
                    Hide();
                    break;
                case "Circle":
                    graphic.FillEllipse(Colorbsh, int.Parse(DUDX.Text), int.Parse(DUDY.Text), int.Parse(DUDWidth.Text), int.Parse(DUDHeight.Text));
                    graphic.Save();
                    frm.Tag = bmp;
                    frm.Show();
                    Hide();
                    break;
                case "Oval":
                    graphic.FillEllipse(Colorbsh, int.Parse(DUDX.Text), int.Parse(DUDY.Text), int.Parse(DUDWidth.Text), int.Parse(DUDHeight.Text));
                    graphic.Save();
                    frm.Tag = bmp;
                    frm.Show();
                    Hide();
                    break;
                case "Line":
                    graphic.DrawLine(new Pen(Colorbsh), int.Parse(DUDX.Text), int.Parse(DUDY.Text), int.Parse(DUDWidth.Text), int.Parse(DUDHeight.Text));
                    graphic.Save();
                    frm.Tag = bmp;
                    frm.Show();
                    Hide();
                    break;
                default:
                    break;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show(); Hide();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();
            DialogResult dsl = colordialog.ShowDialog();
            if (dsl== DialogResult.OK)
            {
                color = colordialog.Color;
                BtnColor.BackColor = colordialog.Color;
            }
        }
    }
}
