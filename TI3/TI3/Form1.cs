using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private byte[] fileB;
        private short[] fileS;
        private int p;
        private int g;
        private int x;
        private int y;

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            p = int.Parse(Regex.Replace(input, "[^0-9]", ""));
            if (Cript.IsPrime(p))
            {
                Cript.FindPrimitiveRoot(p, richTextBox3);
            }
            else
            {
                MessageBox.Show("p не простое", "Warning", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = textBox2.Text;
            g = int.Parse(Regex.Replace(input, "[^0-9]", ""));
            if (Cript.IsPrimitiveRoot(g, p))
            {
                x = Convert.ToInt32(textBox3.Text);
                y = Cript.FastModularExponentiation(g, x, p);
                textBox4.Text = y.ToString();
                textBox5.Text = "(" + textBox1.Text + "," + textBox2.Text + "," + textBox4.Text + ")";
            }
            else
            {
                MessageBox.Show("g не верное", "Warning", MessageBoxButtons.OK);
            }
            
        }

        private void bOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C://Users//User//RiderProjects//TI3//TI3//bin//Debug";
                
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileB = Cript.ReadBinaryFile(openFileDialog.FileName);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in fileB)
                {
                    sb.AppendFormat("{0} ", b);
                }
                richTextBox1.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show("Файл не выбран");
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C://Users//User//RiderProjects//TI3//TI3//bin//Debug";
                
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileS = Cript.ReadShortFile(openFileDialog.FileName);
                StringBuilder sb = new StringBuilder();
                foreach (short b in fileS)
                {
                    sb.AppendFormat("{0} ", b);
                }
                richTextBox1.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show("Файл не выбран");
            }
        }
        
        

        private void button5_Click(object sender, EventArgs e)
        {
            string input = textBox6.Text;
            int k = int.Parse(Regex.Replace(input, "[^0-9]", ""));
            if (Cript.GCD(p, k) == 1)
            {
                int a = Cript.FastModularExponentiation(g, k, p);
                int b,tempY,tempM;
                short[] res = new short[fileB.Length * 2];
                for (int i = 0; i < fileB.Length; i++)
                {
                    tempY = Cript.FastModularExponentiation(y, k, p);
                    tempM = Cript.FastModularExponentiation(Convert.ToInt32(fileB[i]), 1, p);
                    b = Cript.FastModularExponentiation(tempM * tempY, 1, p);
                    res[i * 2] = Convert.ToInt16(a);
                    res[i * 2 + 1] = Convert.ToInt16(b);
                }
                StringBuilder sb = new StringBuilder();
                foreach (short s in res)
                {
                    sb.AppendFormat("{0} ", s);
                }

                richTextBox2.Text = sb.ToString();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "C://Users//User//RiderProjects//TI3//TI3//bin//Debug";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Cript.WriteShortFile(saveFileDialog.FileName,res);
                }
            }
            else
            {
                MessageBox.Show("к и p не взаимно простые");
            }
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            List<byte> resultList = new List<byte>();
            int a, b,tempA,tempB,m;
            for (int i = 0; i < fileS.Length/2; i++)
            {
                a = fileS[i*2];
                b = fileS[i*2 + 1];
                tempB = Cript.FastModularExponentiation(b, 1, p);
                tempA = Cript.FastModularExponentiation(a, p-1-x, p);
                m = Cript.FastModularExponentiation(tempA * tempB, 1, p);
                resultList.Add(Convert.ToByte(m));
            }
            byte[] res = resultList.ToArray();
            StringBuilder sb = new StringBuilder();
            foreach (byte by in res)
            {
                sb.AppendFormat("{0} ", by);
            }
            richTextBox2.Text = sb.ToString();
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "C://Users//User//RiderProjects//TI3//TI3//bin//Debug";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog.FileName, res);
            }
            else
            {
                MessageBox.Show("Файл не выбран");
            }
        }
    }
}