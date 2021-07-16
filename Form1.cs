using System;
using System.IO;
using System.Windows.Forms;


/*
 firstfile content { binary array } secondfile

 for example memject by danielkrupinski
 1st file contains everyting before default array, 2nd file everything after that, and outputFile with ".c" as output
 */


namespace DLLtoHEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dllPath, firstfile, secondfile, outputFolder, FileFormat, outputFile = "DLLtoHEX";
        readonly string[] Formats = { "", ".txt", ".cpp", ".c" };
        bool fFileSetted = false, sFileSetted = false, oSetted = false;


        void FileDialog(Button button, ref string s, ref bool b)
        {
            OpenFileDialog open = new()
            {
                Filter = "TXT|*.txt;"
            };
            if (open.ShowDialog(this) == DialogResult.OK)
            {
                button.ForeColor = System.Drawing.Color.Green;
                button.Text = "file setted";
                s = open.FileName;
                b = true;
            }
        }
        void FolderDialog(Button button, ref string s, ref bool b)
        {
            FolderBrowserDialog open = new();
            if (open.ShowDialog(this) == DialogResult.OK)
            {
                button.ForeColor = System.Drawing.Color.Green;
                button.Text = "output setted";
                s = open.SelectedPath;
                b = true;
            }
        }

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
            FileDialog(setFirstFile_b, ref firstfile, ref fFileSetted);
        }

        private void SetSecondFile_b_Click(object sender, EventArgs e)
        {
            FileDialog(setSecondFile_b, ref secondfile, ref sFileSetted);
        }

        private void SetOutput_b_Click(object sender, EventArgs e)
        {
            FolderDialog(setOutput_b, ref outputFolder, ref oSetted);
        }

        private void Main_b_Click(object sender, EventArgs e)
        {
            if (fFileSetted == true && sFileSetted == true && oSetted == true)
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
                byte[] hex = File.ReadAllBytes(dllPath);
                File.WriteAllText(outputFile, String.Empty); //clear output file
                using (StreamWriter sw = new(outputFile))
                {
                    sw.Write(File.ReadAllText(firstfile) + "{ ");
                    for (int x = 0; x < hex.Length; x++)
                    {
                        sw.Write("0x");
                        sw.Write("{0:X2}", hex[x]);
                        sw.Write(", ");
                        if (((x + 1) % 16) == 0)
                            sw.WriteLine();
                    }
                    sw.Write("};" + '\n' + File.ReadAllText(secondfile));
                }

                FileInfo sizebyte = new(outputFile);
                textBox1.Text = (textBox1.Text + (sizebyte.Length / 1024).ToString() + " Kb");

                MessageBox.Show("Output path:" + '\n' + outputFile, "DLLtoHEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult dResult = MessageBox.Show("Exit?", "DLLtoHEX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else if (fFileSetted == false)
            {
                DialogResult dResult = MessageBox.Show("First file not setted, set it now?", "DLLtoHEX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dResult == DialogResult.Yes)
                {
                    FileDialog(setFirstFile_b, ref firstfile, ref fFileSetted);
                }
            }
            else if (sFileSetted == false)
            {
                DialogResult dResult = MessageBox.Show("Second file not setted, set it now?", "DLLtoHEX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dResult == DialogResult.Yes)
                {
                    FileDialog(setSecondFile_b, ref secondfile, ref sFileSetted);
                }
            }
            else if (oSetted == false)
            {
                DialogResult dResult = MessageBox.Show("Output file not setted, set it now?", "DLLtoHEX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dResult == DialogResult.Yes)
                {
                    FolderDialog(setOutput_b, ref outputFolder, ref oSetted);
                }
            }
        }
    }
}