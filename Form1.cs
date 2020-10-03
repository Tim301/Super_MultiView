using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLCTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "https://www.learningcontainer.com/wp-content/uploads/2020/05/sample-mp4-file.mp4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vlcControl1.Play(new Uri(textBox1.Text));
            button2.Text = "Pause";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( button2.Text == "Pause")
            {
                vlcControl1.Pause();
                button2.Text = "Play";
            }
            else if ( button2.Text == "Play")
            {
                vlcControl1.Play();
                button2.Text = "Pause";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //vlcControl1.Stop();
            vlcControl1.Audio.ToggleMute();
        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {
           //vlcControl1.Audio.Volume = 0;
            Console.WriteLine("Toggle audio");
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
            Console.WriteLine("test");
        }
    }
}
