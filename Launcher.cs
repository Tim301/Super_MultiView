using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace VLCTest
{
    public partial class Launcher : Form
    {
        public System.IO.DirectoryInfo VLC_Dir = new System.IO.DirectoryInfo(@"C:\Program Files\VideoLAN\VLC");
        public Launcher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "1x1") {
                Form1 test = new Form1();
                test.Show();
            }
            if (comboBox1.SelectedItem == "3x3")
            {
                Form1 test = new Form1();
                test.Show();
            }
            if (comboBox1.SelectedItem == "4x4")
            {
                Layout_16 test = new Layout_16();
                test.Show();
            }

            Console.WriteLine(comboBox1.SelectedItem);        

        }

        private void vLCDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Folder = new FolderBrowserDialog();
            Folder.ShowDialog();
            VLC_Dir = new System.IO.DirectoryInfo(Folder.SelectedPath);
            Console.WriteLine(VLC_Dir.ToString());
        }

        //private static BitmapSource CopyScreen()
        //{
        //    var left = Screen.AllScreens.Min(screen => screen.Bounds.X);
        //    var top = Screen.AllScreens.Min(screen => screen.Bounds.Y);
        //    var right = Screen.AllScreens.Max(screen => screen.Bounds.X + screen.Bounds.Width);
        //    var bottom = Screen.AllScreens.Max(screen => screen.Bounds.Y + screen.Bounds.Height);
        //    var width = right - left;
        //    var height = bottom - top;

        //    using (var screenBmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
        //    {
        //        using (var bmpGraphics = Graphics.FromImage(screenBmp))
        //        {
        //            bmpGraphics.CopyFromScreen(left, top, 0, 0, new System.Drawing.Size(width, height));
        //            return Imaging.CreateBitmapSourceFromHBitmap(
        //                screenBmp.GetHbitmap(),
        //                IntPtr.Zero,
        //                Int32Rect.Empty,
        //                BitmapSizeOptions.FromEmptyOptions());
        //        }
        //    }
        //}

    }
}
