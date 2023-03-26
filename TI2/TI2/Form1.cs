using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        byte[] ResultBytes;
        [SuppressMessage("ReSharper.DPA", "DPA0000: DPA issues")]
        async Task WriteKey(string key, RichTextBox r )
        {
            r.AppendText(key);
        }
        [SuppressMessage("ReSharper.DPA", "DPA0000: DPA issues")]
        async Task WriteFile(BitArray bitF, RichTextBox r)
        {
            string bitString = "";
            for (int i = 0; (i < bitF.Length); i++)
            {
                bitString += bitF[i] ? "1" : "0";
                if (i % 2000 == 0)
                {
                    r.AppendText(bitString);
                    bitString = string.Empty;
                }
                        
            }
            r.AppendText(bitString);
        }
        
        
        
        static BitArray BitsSift;
        static bool ShiftAndAdd()
        {
            bool newBit = BitsSift[0] ^ BitsSift[25];
            bool save = BitsSift[0];
            for (int i = 0; i <BitsSift.Length-1; i++)
            {
                BitsSift[i] = BitsSift[i + 1];
            }
            BitsSift[35] = newBit;
            return save;
        }
        
        BitArray ReadBit(string key, byte[] bytes)
        {
            BitArray bitsFile = new BitArray(bytes);
            
            BitsSift = new BitArray(key.Select(c => c == '1').ToArray());

            bool v;
            int z1000=0;
            string BitsKey = "";
            for (int i = 0; i < bitsFile.Length; i++)
            {
                v = ShiftAndAdd();  
                if (z1000 == 1000)
                {
                    WriteKey(BitsKey,rKey);
                    BitsKey = string.Empty;
                    z1000 = 0;
                }
                
                bitsFile[i] ^= v ;
                BitsKey += v ? "1" : "0";
                z1000++;
            }
            rKey.AppendText(BitsKey);

            return bitsFile;
        }

        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string key = tKey.Text; 
            key = new string(key.Where(c => c == '0' || c == '1').ToArray());
            if (key.Length == 36)
            {
                
                rFile.Text = string.Empty;
                rEncript.Text = string.Empty;
                rKey.Text = string.Empty;
                    
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "C://Users//User//RiderProjects//TI2//TI2//bin//Debug";
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    byte[] bytes = File.ReadAllBytes(openFileDialog.FileName);

                    BitArray bitF = new BitArray(bytes);

                    WriteFile(bitF,rFile);
                    
                    BitArray ResultBits = ReadBit(key, bytes);

                    WriteFile(ResultBits, rEncript);

                    ResultBytes = new byte[(ResultBits.Length - 1) / 8 + 1];
                    ResultBits.CopyTo(ResultBytes, 0);
                    
                }
                else
                {
                    MessageBox.Show("Файл не выбран");
                }
                
            }
            else
            {
                MessageBox.Show("Неверная длинна ключа");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "C://Users//User//RiderProjects//TI2//TI2//bin//Debug";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog.FileName, ResultBytes);
            }
            else
            {
                MessageBox.Show("Файл не выбран");
            }
        }
    }
}


//101010101010101010101010101010101010
//111111111111111111111111111111111111
//000000001111111111111111111111111111