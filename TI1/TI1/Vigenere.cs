using System;

namespace TI1;

public class Vigenere
{
    public static string Encript(string text, string key)
    {
        char[] table = new char[] {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
        int tableSize = 33;
        string resultText = string.Empty;
        int keyIndex = 0;
        int i = 0;
    
        foreach (char c in text)
        {
                      
            int next = i / key.Length;
            int shift = (Array.IndexOf(table, key[keyIndex]) + next) % tableSize;
            int cipherChar = (Array.IndexOf(table,c)  + shift + 1) % tableSize;
            resultText += table[cipherChar];
            i++;
            keyIndex = (i) % key.Length;
                        
        }
        return resultText;
    }

    public static string Decript(string text, string key)
    {
        char[] table = new char[] {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
        int tableSize = 33;
        string resultText = string.Empty;
        int keyIndex = 0;
        int i = 0;
        
        foreach (char c in text)
        {

            int next = i / key.Length;
            int shift = (Array.IndexOf(table,key[keyIndex]) + next) % tableSize;
            int plainChar = (Array.IndexOf(table,c) - shift - 1 + tableSize) % tableSize;
            resultText += table[plainChar];
            i++;
            keyIndex = (i) % key.Length;
                        
                       
        }
        
        return resultText;
    }
}