using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Editor
{
    public partial class FormMain : Form
    {
        // Adderss file
        string ImgPath = "";
        // Tools Motiger
        int CountTimePCS = 0;
        int Rotate = 0;
        // Crop
        bool SystemCrop = false;
        int x1, y1 = 0;
        int x2, y2 = 0;
        int Toach = 0;
        bool ResultCrop = false;
        // add img
        bool AddImg = false;
        // Check color
        bool ColorCmTools = false;
        // Tools
        Brush brush;
        bool TSPen = false;bool TSClickMePen = false;
        bool TSEraser = false; bool TSClickMeEraser = false;
        Color colorMain = Color.White;
        bool WriteText = false;
        Font fontText = new Font(DefaultFont, FontStyle.Regular);

        public FormMain()
        {
            InitializeComponent();
            StatusInFo.BackColor = Color.FromArgb(220, 41, 57, 85);
            MenuStripMain.BackColor = Color.FromArgb(0, 122, 204);
            ToolStripMXZ.BackColor = Color.FromArgb(168, 0, 122, 204);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if ((Bitmap)this.Tag != null)
            {
                PictureBoxMain.Image = (Bitmap)this.Tag;
            }

        }

        public Image GetImgPC
        {
            get { return PictureBoxMain.Image; }
            set { GetImgPC = value; }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open file 
            OpenFileDialog dialogfile = new OpenFileDialog();
            dialogfile.Title = "Choose file";
            dialogfile.Multiselect = false;
            dialogfile.Filter = "All Files|*.*|PNG |*.png|JPG |*.jpg|BMP |*.bmp";
            DialogResult SwmDia = dialogfile.ShowDialog();
            if (SwmDia == DialogResult.OK)
            {
                ImgPath = dialogfile.FileName;
                if (ImgPath != "")
                    try
                    {
                        PictureBoxMain.Image = new Bitmap(ImgPath);
                        this.Width = PictureBoxMain.Image.Width + 90;
                        this.Height = PictureBoxMain.Image.Height + 130;
                    }
                    catch
                    {
                        MessageBox.Show("فایل تصویری مناسب انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InOutFileDir imgCm = new InOutFileDir();
            DialogResult MsgResult = MessageBox.Show("رنگ پشت زمینه بی رنگ باشد ؟", "رنگ تصویر", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (MsgResult)
            {
                case DialogResult.Yes:
                    brush = Brushes.Transparent;
                    break;
                case DialogResult.No:
                    brush = Brushes.White;
                    break;
                default:
                    break;
            }
            imgCm.CreateImg("Test1.png", 512, 512, brush);
            ImgPath = imgCm.PathAppDir + "\\Test1.png";
            PictureBoxMain.Image = new Bitmap(imgCm.PathAppDir + "\\Test1.png");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "PNG |*.png|JPG |*.jpg|BMP |*.bmp";
            savefile.DefaultExt = ".png";
            savefile.Title = "Save file";
            DialogResult dg = savefile.ShowDialog();
            if (dg == DialogResult.OK && savefile.FileName != "")
            {
                PictureBoxMain.Image.Save(savefile.FileName);
            }
        }

        private void claerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBoxMain.Image = new Bitmap(Properties.Resources.picture77);
        }

        private void propertiesPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImgPath != "")
            {
                StringBuilder strb = new StringBuilder();

                strb.Append("- Name : " + Path.GetFileName(ImgPath) + '\n');
                strb.Append("- Type file : " + Path.GetExtension(ImgPath) + '\n');

                float SizeImg = new FileInfo(ImgPath).Length;
                float Kbit = 0, MgBit = 0;
                Kbit = SizeImg / 1024;
                if (Kbit < 1024)
                {
                    strb.Append("- Lenght : " + Math.Round(Kbit, 2) + " KB " + '\n');
                }
                else
                {
                    MgBit = Kbit / 1024;
                    strb.Append("- Lenght : " + Math.Round(MgBit, 2) + " MB " + '\n');
                }
                strb.Append("- Location : " + ImgPath + '\n');
                strb.AppendLine();
                strb.Append("- Width : " + PictureBoxMain.Image.Width + '\n');
                strb.Append("- Height : " + PictureBoxMain.Image.Height + '\n');
                strb.Append("- Bit depth : " + PictureBoxMain.Image.PixelFormat.ToString());

                MessageBox.Show(strb.ToString(), "Info Iamge", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void managerDIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Delete memoory files", "Claer DIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                Directory.Delete(new InOutFileDir().PathAppDir, true);
                Directory.CreateDirectory(new InOutFileDir().PathAppDir);
            }
        }

        private void ToolSpPen_Click(object sender, EventArgs e)
        {
            TSPen = (TSPen == true) ? false : true;
        }

        private void screenShotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(500); // Stop app ==> Screen copy
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;

            Bitmap bitmap = new Bitmap(width, height);
            Graphics graphic = Graphics.FromImage(bitmap);
            graphic.CopyFromScreen(Point.Empty, Point.Empty, new Size(width, height));
            string path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Screenshot" + new Random().Next(100) + ".png");
            bitmap.Save(path);
            PictureBoxMain.Image = bitmap;
            // Load Form
            this.Show();
        }

        private void PictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            #region Pen 
            // Pen 
            TSClickMePen = TSClickMePen == false ? true : false;
            TSClickMeEraser = TSClickMeEraser == false ? true : false;
            #endregion

            #region Crop

            // crop click
            Bitmap bitmap = new Bitmap(PictureBoxMain.Image);
            if (ResultCrop)
            {
                PictureBoxMain.Image = bitmap.Clone(new Rectangle(x1 + 2, y1 + 2, x2 - x1 - 2, y2 - y1 - 2), bitmap.PixelFormat);
                PictureBoxMain.Cursor = Cursors.Default;
                ResultCrop = false;
            }
            // crop
            if (SystemCrop)
            {
                try
                {
                    switch (Toach)
                    {
                        case 0:
                            x1 = e.X;
                            y1 = e.Y;
                            Toach++;
                            break;
                        case 1:
                            x2 = e.X;
                            y2 = e.Y;
                            Bitmap Bmp = new Bitmap(PictureBoxMain.Image);
                            Graphics graphic = Graphics.FromImage(Bmp);
                            graphic.DrawRectangle(new Pen(Color.OrangeRed), new Rectangle(x1, y1, x2 - x1, y2 - y1));
                            graphic.Save();
                            PictureBoxMain.Image = Bmp;
                            PictureBoxMain.Cursor = Cursors.Hand;
                            Toach = 0;
                            SystemCrop = false;
                            ResultCrop = true;
                            break;
                        default:
                            break;
                    }
                }
                catch { }
            }

            #endregion

            #region Add Img
            // add img
            if (AddImg)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open file";
                ofd.Multiselect = false;
                ofd.Filter = "All Files|*.*|PNG |*.png|JPG |*.jpg|BMP |*.bmp";
                DialogResult Rsdialog = ofd.ShowDialog();
                if (Rsdialog == DialogResult.OK)
                {
                    Graphics graphic = Graphics.FromImage(bitmap);
                    graphic.DrawImage(Image.FromFile(ofd.FileName), new PointF(e.X, e.Y));
                    graphic.Save();
                    PictureBoxMain.Image = bitmap;
                    AddImg = false;
                    PictureBoxMain.Cursor = Cursors.Default;
                }
            }
            #endregion

            #region retrun Color 

            if (ColorCmTools)
            {
                Color InfoColorImg = new Bitmap(PictureBoxMain.Image).GetPixel(e.X, e.Y);
                string Pfx = "X : " + e.X + "  Y : " + e.Y +'\n' + "Color : " + "( R : " + InfoColorImg.R + " , G : " + InfoColorImg.G +
                    " , B : " + InfoColorImg.B +" )"+'\n'+ "Name color : #" + InfoColorImg.Name + "\nBrightness : " + InfoColorImg.GetBrightness()+ "\nSaturation : "
                    + InfoColorImg.GetSaturation() + "\nPixelFormat : " + new Bitmap(PictureBoxMain.Image).PixelFormat + "\nSize : " + new Bitmap(PictureBoxMain.Image).Size;
                MessageBox.Show(Pfx, "Info img ");
                ColorCmTools = false;
                PictureBoxMain.Cursor = Cursors.Default;
            }

            #endregion

            #region Add Text 
            if (WriteText)
            {
                Bitmap bgmp = new Bitmap(PictureBoxMain.Image);
                Graphics graphic = Graphics.FromImage(bgmp);
                graphic.DrawString(WriteToImg.Text, fontText, new SolidBrush(colorMain), new Point(e.X, e.Y));
                graphic.Save();
                PictureBoxMain.Image = bgmp;
                PictureBoxMain.Cursor = DefaultCursor;
                WriteText = false;
            }
            #endregion
        }

        private void PictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Color InfoColorImg = new Bitmap(PictureBoxMain.Image).GetPixel(e.X, e.Y);
                InfoImgP.Text = "X : " + e.X + "  Y : " + e.Y + "   " + "Color : " + "( R : " + InfoColorImg.R + " , G : " + InfoColorImg.G + " , B : " + InfoColorImg.B + " )  Brightness : " + InfoColorImg.GetBrightness();
            }
            catch { }
            //pen
            if (TSPen && TSClickMePen)
            {
                Bitmap bitmap = new Bitmap(PictureBoxMain.Image);
                Graphics graphic = Graphics.FromImage(bitmap);
                graphic.FillEllipse(new SolidBrush(colorMain), new RectangleF(e.Location, new Size(10, 10)));
                graphic.Save();
                PictureBoxMain.Image = bitmap;
            }
            // Eraser
            if (TSEraser && TSClickMeEraser)
            {
                Bitmap bitmap = new Bitmap(PictureBoxMain.Image);
                Graphics graphic = Graphics.FromImage(bitmap);
                graphic.FillRectangle(Brushes.White, new RectangleF(e.Location, new Size(10, 10)));
                graphic.Save();
                PictureBoxMain.Image = bitmap;
            }
        }

        private void PictureBoxMain_Click(object sender, EventArgs e)
        {

        }

        private void whiteBlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process ProcessImg = Process.GetCurrentProcess();
            Bitmap bitmap = new Bitmap(PictureBoxMain.Image);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color colorChange = bitmap.GetPixel(i, j);
                    int Avrage = (colorChange.B + colorChange.G + colorChange.R) / 3;
                    if (Avrage < 100)
                    {
                        bitmap.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        bitmap.SetPixel(i, j, Color.White);
                    }
                }
            }
            
            PictureBoxMain.Image = bitmap;
            InfoImgP.Text = "White/Black Done - Total Processor Time : " + (ProcessImg.TotalProcessorTime.Seconds - CountTimePCS) + " S";
            CountTimePCS = ProcessImg.TotalProcessorTime.Seconds;
            MessageBox.Show("White/Black Done", "Process image", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void autoSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autoSizeToolStripMenuItem.Checked)
            {
                PictureBoxMain.SizeMode = PictureBoxSizeMode.Normal;
                autoSizeToolStripMenuItem.Checked = false;
            }
            else
            {
                PictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
                autoSizeToolStripMenuItem.Checked = true;
            }
        }

        private void addImgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (AddImg)
            {
                case false:
                    AddImg = true;
                    PictureBoxMain.Cursor = Cursors.Cross;
                    break;
                case true:
                    AddImg = false;
                    PictureBoxMain.Cursor = Cursors.Default;
                    ResultCrop = false;
                    break;
                default:
                    break;
            }
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormResize frm = new FormResize();
            frm.Tag = ImgPath;
            frm.ShowDialog();
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap BmpRt = new Bitmap(PictureBoxMain.Image);
            switch (Rotate)
            {
                case 0:
                    BmpRt.RotateFlip(RotateFlipType.Rotate180FlipXY);
                    Rotate++;
                    break;
                case 1:
                    BmpRt.RotateFlip(RotateFlipType.Rotate270FlipXY);
                    Rotate++;
                    break;
                case 2:
                    BmpRt.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    Rotate = 0;
                    break;
                default:
                    break;
            }
            PictureBoxMain.Image = BmpRt;
        }

        private void ToolSpColor_Click(object sender, EventArgs e)
        {
            ColorDialog dgColor = new ColorDialog();
            dgColor.Color = colorMain;
            DialogResult ResultDC = dgColor.ShowDialog();
            if (ResultDC == DialogResult.OK)
            {
                colorMain = dgColor.Color;
            }
        }

        private void ToolSpSmColor_Click(object sender, EventArgs e)
        {
            ColorCmTools = (ColorCmTools == false) ? true : false;
            if (ColorCmTools)
            {
                PictureBoxMain.Cursor = Cursors.Cross;
            }
            else
            {
                PictureBoxMain.Cursor = Cursors.Default;
            }
        }

        private void ToolSpColorBS_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(PictureBoxMain.Image);
            Graphics graphic = Graphics.FromImage(bitmap);
            graphic.FillRectangle(new SolidBrush(colorMain), new Rectangle(new Point(0, 0), new Size(bitmap.Width, bitmap.Height)));
            graphic.Save();
            PictureBoxMain.Image = bitmap;
        }

        private void ToolSpText_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Select to font ?", "Write text", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            PictureBoxMain.Cursor = Cursors.IBeam;
            switch (result)
            {
                case DialogResult.Cancel:
                    PictureBoxMain.Cursor = DefaultCursor;
                    WriteText = false;
                    break;
                case DialogResult.Yes:
                    FontDialog fontdef = new FontDialog();
                    DialogResult dgr = fontdef.ShowDialog();
                    if (dgr == DialogResult.OK)
                    {
                        fontText = fontdef.Font;
                        WriteText = WriteText == false ? true : false;
                    }
                    break;
                case DialogResult.No:
                    WriteText = WriteText == false ? true : false;
                    break;
                default:
                    break;
            }
        }

        private void ToolStripButtonEraser_Click(object sender, EventArgs e)
        {
            TSEraser = TSEraser == true ? false : true;
        }

        private void ToolSpPointer_Click_1(object sender, EventArgs e)
        {
            PictureBoxMain.Cursor = Cursors.Default;
            // false to motaghir
            ColorCmTools = false;
            WriteText = false;
            TSPen = false;
            TSClickMePen = false;
            TSEraser = false;
            TSClickMeEraser = false;
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App Editor \nDeveloper : Mahdi Khayamdar\nDate : 5/20/2018", "About me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void shapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormShapes fs = new FormShapes();
            fs.Tag = PictureBoxMain.Image;
            fs.ShowDialog();
        }

        private void corpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (SystemCrop)
            {
                case false:
                    SystemCrop = true;
                    PictureBoxMain.Cursor = Cursors.Cross;
                    break;
                case true:
                    SystemCrop = false;
                    PictureBoxMain.Cursor = Cursors.Default;
                    break;
                default:
                    break;
            }
        }
    }
}
