
namespace TI1
{
    public class Railways
    {
        public static string Encript(string text,int key)
        {
            if (key < 1) return null;
            if (key == 1) return text;
            
            char[,] charMatrix = new char[key,text.Length];

            bool dirDown = false;
            int row = 0, col = 0;

            for (int i = 0; i < key; i++)               
            {
                for (int j = 0; j < text.Length; j++) {
                    charMatrix[i,j] = '\n';
                }
            }

            for (int i = 0; i < text.Length; i++){
                if (row == 0 || row == key-1)
                    dirDown = !dirDown;
                charMatrix[row,col++] = text[i];
                if (dirDown)
                    row++;
                else
                    row--;
            }

            string resultText = string.Empty;
            for (int i = 0; i < key; i++)
            for (int j = 0; j < text.Length; j++){
                if (charMatrix[i,j] != '\n')
                    resultText += charMatrix[i,j];
            }
            return resultText;
        }

        public static string Decript(string text, int key)
        {
            if (key < 1) return null;
            if (key == 1) return text;
            char[,] charMatrix = new char[key,text.Length];

            bool dir_down = false;
            int row = 0, col = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (row == 0 || row == key-1)
                    dir_down = !dir_down;
                charMatrix[row,col++] = '\n';
                if (dir_down)
                    row++;
                else
                    row--;
            }

            int ind = 0;
            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < text.Length; j++) {
                    if (charMatrix[i,j] == '\n')
                        charMatrix[i,j] = text[ind++];
                }
            }

            string resultText = string.Empty;
            row = 0;
            col = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (row == 0)
                    dir_down = true;
                if (row == key - 1)
                    dir_down = false;
                resultText += charMatrix[row,col++];
                if (dir_down)
                    row++;
                else
                    row--;
            }
            return resultText;
        }
    }
}