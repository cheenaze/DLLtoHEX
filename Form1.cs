using System;
using System.IO;
using System.Windows.Forms;

namespace DLLtoHEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Output file size: ";
        }

        string dllPath, firstfile, secondfile, outputFolder, FileFormat, outputFile = "DLLtoHEX";
        readonly string[] Formats = { "", ".txt", ".cpp", ".c" };

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            FileFormat = Formats[0];
        }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FileFormat = Formats[1];
        }
        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            FileFormat = Formats[2];
        }
        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            FileFormat = Formats[3];
        }


        private void SetFirstFile_b_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new()
            {
                Filter = "TXT|*.txt;"
            };

            if (open.ShowDialog(this) == DialogResult.OK)
            {
                setFirstFile_b.ForeColor = System.Drawing.Color.Green;
                setFirstFile_b.Text = "file setted";
                firstfile = open.FileName;
            }
        }

        private void SetSecondFile_b_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new()
            {
                Filter = "TXT|*.txt;"
            };

            if (open.ShowDialog(this) == DialogResult.OK)
            {
                setSecondFile_b.ForeColor = System.Drawing.Color.Green;
                setSecondFile_b.Text = "file setted";
                secondfile = open.FileName;
            }
        }

        private void SetOutput_b_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new();
            if (open.ShowDialog(this) == DialogResult.OK)
            {
                setOutput_b.ForeColor = System.Drawing.Color.Green;
                setOutput_b.Text = "output setted";
                outputFolder = open.SelectedPath;
            }
        }


        private void Main_b_Click(object sender, EventArgs e)
        {
            if (firstfile.Length != 0 && secondfile.Length != 0 && outputFolder.Length != 0)
            {
                OpenFileDialog openDialog = new()
                {
                    Filter = "DLL|*.dll;"
                };

                if (openDialog.ShowDialog(this) == DialogResult.OK)
                {
                    dllPath = openDialog.FileName;
                }
                outputFile = outputFolder + "\\" + outputFile + FileFormat;
                MessageBox.Show(outputFile, "");
                byte[] hex = File.ReadAllBytes(dllPath);
                File.WriteAllText(outputFile, String.Empty);
                using (StreamWriter sw = new(outputFile))
                {
                    sw.Write(File.ReadAllText(firstfile));
                    for (int x = 0; x < hex.Length; x++)
                    {
                        sw.Write("0x");
                        sw.Write("{0:X2}", hex[x]);
                        sw.Write(", ");
                        if (((x + 1) % 16) == 0)
                            sw.WriteLine();
                    }
                    sw.Write(File.ReadAllText(secondfile));
                }

                FileInfo sizebyte = new(outputFile);
                long size_kbyte = sizebyte.Length / 1024;
                textBox1.Text = ("Output file size: " + size_kbyte.ToString() + " Kb");

                DialogResult result = MessageBox.Show("Exit?", "DLLtoHEX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Smth wrong", "DLLtoHEX");
            }
        }
    }
}