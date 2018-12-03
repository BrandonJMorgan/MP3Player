using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_player // name of the app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] files, path; 

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex]; // plays the selcted file
        }
        // Made by Brandon
        // below is the code that controls the button and the open file dialog box I added 
        private void playButton_Click(object sender, EventArgs e) 
        {
            // actully opens the dialog 
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                path = openFileDialog1.FileNames;
                for (int i = 0; i < files.Length; i++) // collect the names of selected files
                {
                    listBox1.Items.Add(files[i]); // collect the names of selected files
                }
            }
        }
    }
}
