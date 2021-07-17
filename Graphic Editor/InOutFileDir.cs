using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
namespace Graphic_Editor
{
    class InOutFileDir
    {
        //string PathAppDir = @"C:\Users\" + System.Environment.UserName + @"\Documents\Application Graphic Editer";
        public string PathAppDir = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Application Graphic Editer");

        protected string PFileImg = "";

        public InOutFileDir()
        {
            if (!Directory.Exists(PathAppDir))
                Directory.CreateDirectory(PathAppDir);
        }

        public void CreateImg(string name, int height, int width, System.Drawing.Brush b)
        {
            Bitmap BitImg = new Bitmap(width, height);
            Graphics gr = Graphics.FromImage(BitImg);
            gr.FillRectangle(b, 0, 0, width, height);
            gr.Save();
            BitImg.Save(PathAppDir + "\\" + name);
        }

        public string PathFileImg
        {
            set { value = PFileImg; }
            get { return PFileImg; }
        }

    }
}
