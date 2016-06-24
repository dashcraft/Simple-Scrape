using System;
using System.IO;
using System.Net;
using System.Windows.Forms;




namespace Vendor_Image_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();



            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel Files (*.xlsx)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Insert code to read the stream here.

                    string filename = openFileDialog1.FileName;
                    Console.WriteLine(filename);

                    StreamReader ifile;
                    string toPath = "C:\\Users\\" + Environment.UserName + "\\Documents\\Images\\";

                    ifile = File.OpenText(filename);
                    Console.WriteLine(Environment.UserName);
                   

                    if (!Directory.Exists(toPath))
                    {
                        Directory.CreateDirectory(toPath);
                    }
                    else
                    {
                        Directory.CreateDirectory(toPath + "\\Products");
                    }



                    while (!ifile.EndOfStream)
                    {
                        string[] s = ifile.ReadLine().Split(',');

                        if (s[1] != "" && s[2] != "")
                        {

                            Console.WriteLine(toPath + s[0] + "-1");
                            Console.WriteLine(s[1]);
                            WebClient webClient = new WebClient();
                            webClient.DownloadFile(s[1], toPath + s[0] + "-1.jpg");
                            webClient.DownloadFile(s[2], toPath + s[0] + "-2.jpg");
                            Console.WriteLine(s[0] + s[1] + s[2]);

                        }



                      

       
                    }

                
                  

                }


                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
