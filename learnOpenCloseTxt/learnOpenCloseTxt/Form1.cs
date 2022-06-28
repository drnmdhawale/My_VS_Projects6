using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnOpenCloseTxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
           string file_name = "\\test1.txt";
           file_name = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + file_name;

           //if (System.IO.Directory.Exists(folder_location))
           //{
           //}

           if ( System.IO.File.Exists( file_name ) == true )
            {
                System.IO.StreamReader objReader; 
                objReader = new System.IO.StreamReader(file_name);
           
                textBox1.Text = objReader.ReadToEnd();
           
                objReader.Close();
            }
            else
            {
                MessageBox.Show("No such File " + file_name);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string file_name = "\\test2.txt";
            file_name = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + file_name;


            System.IO.StreamWriter objWriter;
            objWriter = new System.IO.StreamWriter(file_name, true);
            
            objWriter.Write(textBox1.Text);
            objWriter.Close();
           
            MessageBox.Show("Wrote File");

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string fileToCopy = "C:\\Users\\Shree\\Documents\\test1.txt";
            string newLocation = "C:\\Users\\Shree\\Documents\\copiedFiles\\test1.txt";
            string folderLocation = "C:\\Users\\Shree\\Documents\\copiedFiles";
            //file_name = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + file_name;


            if ( System.IO.Directory.Exists(folderLocation))
            {
                if ( System.IO.File.Exists(fileToCopy))
                {
                    System.IO.File.Copy(fileToCopy, newLocation, true);
                    //System.IO.File.Move(fileToMove, fileLocation);
                    //System.IO.File.Delete( file_path );
                     MessageBox.Show("File Copied");
           
                }
                else
                {
                    MessageBox.Show("No such File ");
                }
            }
            
            else
            {
                MessageBox.Show("No such Directory ");
            }

            
           
        }
    }
}
