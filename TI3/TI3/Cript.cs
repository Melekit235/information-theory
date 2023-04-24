using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TI3
{
    public class Cript
    { public static bool IsPrime(int number) {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0) return false;
            return true;
        }

        public static int RandG(int p)
        {
            int el = p - 1;
            Random rand = new Random();
            int g = rand.Next(2, p-1);
            while (GCD(g, p) != 1)
            {
                g = rand.Next(2, p-1);
            }
            for (int q = 2; q <= el; q++)
            {
                if (el % q == 0)
                {
                    int exp = el / q;
                    int mod = (int)Math.Pow(g, exp) % p;

                    if (mod == 1)
                    {
                        while (GCD(g, p) != 1)
                        {
                            g = rand.Next(2, p-1);
                        }
                        q = 1;
                    }
                }
            }
            return g;
        }
        
        
        
        
        
        public static void FindPrimitiveRoot(int p, RichTextBox rtb)
        {
            for (int g = 2; g < p; g++)
            {
                if (IsPrimitiveRoot(g, p))
                {
                    rtb.AppendText(g+" ");
                }
            }
        }

        public static bool IsPrimitiveRoot(int g, int p)
        {
            int phi = p - 1;
            if (FastModularExponentiation(g, phi, p) != 1)
            {
                return false;
            }

            for (int i = 1; i < phi; i++)
            {
                if (FastModularExponentiation(g, i, p) == 1)
                {
                    return false;
                }
            }

            return true;
        }
        
        
        
        
        
        
        
        
        public static int FastModularExponentiation(int g, int x, int p)
        {
            int y = 1;
            while (x > 0)
            {
                if ((x & 1) == 1)
                {
                    y = (y * g) % p;
                }
                g = (g * g) % p;
                x >>= 1;
            }
            return y;
        }
        
        
        
        
        
        
        
        public static int GenerateCoprime(int n)
        {
            Random rand = new Random();
            int coprime = rand.Next(2, n);
            while (GCD(n, coprime) != 1)
            {
                coprime = (coprime + 1) % n;
            }
            return coprime;
        }
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public static byte[] ReadBinaryFile(string filename)
        {
            List<byte> res= new List<byte>();
            byte[] buf = new byte[100];
            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                    res.Add( reader.ReadByte());
            }
            return res.ToArray();
        }
        public static void WriteBinaryFile(string filename, byte[] arr)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
            {
                for(int i = 0; i < arr.Length;i++)
                    writer.Write(arr[i]);
            }
        }
        public static short[] ReadShortFile(string filename)
        {
            List<short> res= new List<short>();
            short tmp1,tmp2,tmp;
            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    tmp1 = reader.ReadByte();
                    tmp2 = reader.ReadByte();
                    tmp = (short)((tmp2 << 8)|tmp1);
                    res.Add(tmp);
                }
            }
            return res.ToArray();
        }
        public static void WriteShortFile(string filename, short[] arr)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
            {
                for(int i = 0; i < arr.Length;i++)
                    writer.Write(arr[i]);
            }
        }
    }
}