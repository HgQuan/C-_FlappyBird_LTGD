using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Flappy_Bird_Windows_Form
{
    public partial class FormBegin: Form
    {
        //List<int> scores = new List<int>();
        WindowsMediaPlayer sound = new WindowsMediaPlayer();
        string[] score;
        string filename = @"D:\Scores.txt";
        bool playcheck = false;
        int[] scoreInt;
        public FormBegin()
        {
            InitializeComponent();
            sound.URL = "sound.mp3";
            sound.controls.play();
            if (sound.status == "Paused")
                sound.controls.play();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            playcheck = true;
            if(playcheck == true)
                this.Close();
            
        }

        private void btnHighestScore_Click(object sender, EventArgs e)
        {
            //File.Move("", "");
            FileStream fs = new FileStream(filename, FileMode.Open,FileAccess.Read);
            StreamReader read = new StreamReader(fs, UTF8Encoding.UTF8);
            score = File.ReadAllLines(filename);
            //scores.Add(Int32.Parse(score));
            read.Close(); // close streamreader
            fs.Close(); // dong file stream
                        //Label HighestScore = new Label();
                        //HighestScore.Location = new Point(0, 0);
                        //this.Controls.SetChildIndex(HighestScore, 10);
                        //for (int i = 0; i < score.Length; i++)
                        //scoreInt[i] = int.Parse(score[i]);
            scoreInt = Array.ConvertAll<string, int>(score, int.Parse);
            HighestScore.Text = "Highest Scores: " +  scoreInt.Max();
        }

        private void FormBegin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (playcheck == false)
            {
                Application.Exit();
            }
        }
    }
}
