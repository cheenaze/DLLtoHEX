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
        }

        string dllPath;

        readonly string firstfile = "";
        readonly string secondfile = ""; //it was necessary for me

        readonly string output = ""; //YOUR PATH

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog
            {
                Filter = "DLL|*.dll;"
            };

            if (openDialog.ShowDialog(this) == DialogResult.OK)
            {
                dllPath = openDialog.FileName;
            }

            byte[] hex = File.ReadAllBytes(dllPath);
            File.WriteAllText(output, String.Empty);
            using (StreamWriter sw = new StreamWriter(output))
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

            FileInfo sizebyte = new FileInfo(output);
            long size_kbyte = sizebyte.Length / 1024;
            textBox1.Text = (size_kbyte.ToString() + " Kb");

            DialogResult result = MessageBox.Show("Exit?", "DLLtoHEX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }
    }
}
