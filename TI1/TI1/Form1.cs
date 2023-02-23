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



namespace TI1
{
    public partial class Form1 : Form
    {
        
        string readFromFil()
        {
            string inText = string.Empty;
            var fileContent = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Users\\User\\RiderProjects\\TI1\\TI1\\bin\\Debug";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            for (int i = 0; i < fileContent.Length; i++)
            {
                if ((fileContent[i] >= 'а') && (fileContent[i] <= 'я')) //|| ((fileContent[i] >= 'a') && (fileContent[i] <= 'z')))
                        
                    inText += fileContent[i];
            }

            return inText.ToLower();
        }

        public static void writeInFil(string text)
        {
            Stream myStream ;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
 
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"  ;
            saveFileDialog.FilterIndex = 2 ;
            saveFileDialog.RestoreDirectory = true ;
 
            if(saveFileDialog.ShowDialog() != DialogResult.None)
                File.WriteAllText(saveFileDialog.FileName, text);

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void bEncript_Click(object sender, EventArgs e)
        {
            string inText = null;
            int key;
            
            bool bInt = int.TryParse(tEnRail.Text, out key);
            if (!bInt)
                MessageBox.Show("Неверный ключ","ERROR",MessageBoxButtons.OK);
            else
            {
                inText = readFromFil();
                
                rtdEnRail.Text = Railways.Encript(inText, key);
                writeInFil(rtdEnRail.Text);
                
            }
        }

        private void bEnVi_Click(object sender, EventArgs e)
        {
            string inText = null;
            string key = tEnVi.Text.ToLower();
            
            bool bLetter = true;
            for (int i = 0; i < key.Length; i++)
            {
                if ((key[i] <= 'а') || (key[i] >= 'я')) //|| ((fileContent[i] >= 'a') && (fileContent[i] <= 'z')))
                    bLetter = false;
            }
            if (!bLetter)
                MessageBox.Show("Неверный ключ","ERROR",MessageBoxButtons.OK);
            else
            {
                inText = readFromFil();
                
                rtbEnVi.Text = Vigenere.Encript(inText, key);
 
            }
            writeInFil(rtdEnRail.Text);
            
        }

        private void bDeRail_Click(object sender, EventArgs e)
        {
            string inText = null;
            int key;
            
            bool bInt = int.TryParse(tEnRail.Text, out key);
            if (!bInt)
                MessageBox.Show("Неверный ключ","ERROR",MessageBoxButtons.OK);
            else
            {
                inText = readFromFil();
                
                rtbDeRail.Text = Railways.Decript(inText, key);
            }
            writeInFil(rtdEnRail.Text);
        }

        private void bDeVi_Click(object sender, EventArgs e)
        {
            string inText = null;
            string key = tDeVi.Text.ToLower();
            
            bool bLetter = true;
            for (int i = 0; i < key.Length; i++)
            {
                if ((key[i] <= 'а') || (key[i] >= 'я')) //|| ((fileContent[i] >= 'a') && (fileContent[i] <= 'z')))
                    bLetter = false;
            }
            if (!bLetter)
                MessageBox.Show("Неверный ключ","ERROR",MessageBoxButtons.OK);
            else
            {
                inText = readFromFil();
                
                rtbDeVi.Text = Vigenere.Decript(inText, key);
            }
            writeInFil(rtdEnRail.Text);
        }
    }
}