using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_BlockEncrypt
{
    public class BlockEncrypt
    {
        private Matrix _matrix;
        public BlockEncrypt(Matrix matrix)
        {
            _matrix = matrix;
        }
        public string Encrypt(string orgText)
        {
            StringBuilder afterText = new StringBuilder();
            int length = orgText.Length;
            if (length % 2 == 1)
            {
                length -= 1;
            }
            for (int i = 0; i < length; i += 2)
            {
                afterText.Append(encrypt2char(orgText, i));
            }
            if (length != orgText.Length)
            {
                afterText.Append(orgText.ToArray()[length]);
            }
            return afterText.ToString();
        }

        public string Decrypt(string encryptText)
        {
            return Encrypt(encryptText);
        }
        private char[] encrypt2char(string orgText, int startIndex)
        {
            char[,] matrix = _matrix.GetMatrix();
            char[] result = new char[2];
            char A = orgText.ToArray()[startIndex];
            char B = orgText.ToArray()[startIndex + 1];
            int rowIndexOfA = -1;
            int colIndexOfA = -1;
            int rowIndexOfB = -1;
            int colIndexOfB = -1;
            int w = matrix.GetLength(0); // width
            int h = matrix.GetLength(1); // height

            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    if (matrix[x, y] == A)
                    {
                        rowIndexOfA = x;
                        colIndexOfA = y;
                    }
                    if (matrix[x, y] == B)
                    {
                        rowIndexOfB = x;
                        colIndexOfB = y;
                    }
                }
            }
            if (rowIndexOfA == rowIndexOfB || colIndexOfA == colIndexOfB)
            {
                result[0] = B;
                result[1] = A;
            }
            else
            {
                result[0] = matrix[rowIndexOfB, colIndexOfA];
                result[1] = matrix[rowIndexOfA, colIndexOfB];
            }
            return result;

        }
    }
}
