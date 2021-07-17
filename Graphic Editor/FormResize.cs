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
    public partial class FormResize : Form
    {
        public FormResize()
        {
            InitializeComponent();

            for (int i = 0; i < 5000; i++)
            {
                DUD_Height.Items.Add(i);
                DUD_Width.Items.Add(i);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
            FormMain frm = new FormMain();
            frm.Tag = null;
            frm.Show();
        }

        private void BtnResize_Click(object sender, EventArgs e)
        {
            string adderss = (string)this.Tag;
            Bitmap bitmap = new Bitmap(Image.FromFile(adderss), new Size(int.Parse(DUD_Width.Text), int.Parse(DUD_Height.Text)));
            FormMain frm = new FormMain();
            frm.Tag = bitmap;
            frm.Show();
            Close();
        }

        private void FormResize_Load(object sender, EventArgs e)
        {
            
        }
    }
}
