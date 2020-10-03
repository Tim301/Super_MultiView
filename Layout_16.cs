using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core.Interops;

namespace VLCTest
{
    public partial class Layout_16 : Form
    {
        public Layout_16()
        {
            InitializeComponent();
            vlcControl1.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            //vlcControl1.Audio.ToggleMute();
            vlcControl2.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl2.Audio.ToggleMute();
            vlcControl3.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl3.Audio.ToggleMute();
            vlcControl4.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl4.Audio.ToggleMute();
            vlcControl5.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl5.Audio.ToggleMute();
            vlcControl6.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl6.Audio.ToggleMute();
            vlcControl7.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl7.Audio.ToggleMute();
            vlcControl8.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl8.Audio.ToggleMute();
            vlcControl9.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl9.Audio.ToggleMute();
            vlcControl10.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl10.Audio.ToggleMute();
            vlcControl11.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl11.Audio.ToggleMute();
            vlcControl12.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl12.Audio.ToggleMute();
            vlcControl13.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl13.Audio.ToggleMute();
            vlcControl14.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl14.Audio.ToggleMute();
            vlcControl15.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl15.Audio.ToggleMute();
            vlcControl16.Play(new Uri(@"C:\Rent-a-Girlfriend - 01 VOSTFR [1080p].mkv"));
            vlcControl16.Audio.ToggleMute();
            Console.WriteLine("Ici");
            while (!vlcControl2.IsPlaying) { Console.WriteLine("waiting"); }
            var audioTracks = vlcControl2.Audio.Tracks.All.ToArray();
            //vlcControl1.VlcMediaPlayer.
            for (int i=1; i < audioTracks.Length; i++)
            {
                //vlcControl1.Audio.Tracks.Current = audioTracks[i];
                Console.WriteLine(audioTracks[i].Name);
                comboBox1.Items.Add(audioTracks[i].Name);
            }
            if (audioTracks.Length >1) comboBox1.SelectedIndex = 0;
            var videoTracks = vlcControl1.Video.Tracks.All.ToArray();
            for (int i = 1; i < videoTracks.Length; i++)
            {
                //vlcControl1.Audio.Tracks.Current = audioTracks[i];
                Console.WriteLine(videoTracks[i].Name);
            }
            var subTracks = vlcControl1.SubTitles.All.ToArray();
            for (int i = 1; i < subTracks.Length; i++)
            {
                //vlcControl1.Audio.Tracks.Current = audioTracks[i];
                comboBox2.Items.Add(subTracks[i].Name);
            }
            if (subTracks.Length > 1) comboBox2.SelectedIndex = 0;
            //ToggleMute_All();
        }

        public void ToggleMute_All()
        {
            vlcControl1.Audio.ToggleMute();
            vlcControl2.Audio.ToggleMute();
            vlcControl3.Audio.ToggleMute();
            vlcControl4.Audio.ToggleMute();
            vlcControl5.Audio.ToggleMute();
            vlcControl6.Audio.ToggleMute();
            vlcControl7.Audio.ToggleMute();
            vlcControl8.Audio.ToggleMute();
            vlcControl9.Audio.ToggleMute();
            vlcControl10.Audio.ToggleMute();
            vlcControl11.Audio.ToggleMute();
            vlcControl12.Audio.ToggleMute();
            vlcControl12.Audio.ToggleMute();
            vlcControl13.Audio.ToggleMute();
            vlcControl14.Audio.ToggleMute();
            vlcControl15.Audio.ToggleMute();
            vlcControl16.Audio.ToggleMute();
            Console.WriteLine("Coucou");
        }
    }
}
