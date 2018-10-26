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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FileDialog fileDialog = new OpenFileDialog())
            {
                if (DialogResult.OK == fileDialog.ShowDialog())
                {
                    string filename = fileDialog.FileName;

                    string directoryPath = Path.GetDirectoryName(filename);

                    textBox1.Text = fileDialog.FileName;
                    textBox2.Text = directoryPath;
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("we are exiting!!");
            Application.Exit();
        }

        private void btn_create_folders_Click(object sender, EventArgs e)
        {
            //todo

            //find all the files and add them to an array
            string[] array1 = Directory.GetFiles(textBox2.Text);
            //find all the created dates and add them into the array

            //create  folders for above array

            //create arrays for each folder

            //fill it up wiht array

            //add them to the folders
        }
    }
}
