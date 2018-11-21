using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_BlockEncrypt
{
    public struct Position
    {
        public int rowIndexOfA;
        public int colIndexOfA;
        public int rowIndexOfB;
        public int colIndexOfB;
    }
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
            if (rowIndexOfA == -1 || rowIndexOfB == -1)//这两个字符没有在矩阵中找到，则保持原顺序
            {
                result[0] = A;
                result[1] = B;
            }
            else if (rowIndexOfA == rowIndexOfB || colIndexOfA == colIndexOfB)//如果恰好在一行一列，直接互换
            {
                result[0] = B;
                result[1] = A;
            }
            else//如果不在一行或一列，则对角线互换
            {
                result[0] = matrix[rowIndexOfB, colIndexOfA];
                result[1] = matrix[rowIndexOfA, colIndexOfB];
            }
            return result;

        }
        private char[] encrypt2char(string orgText, int startIndex, out Position position)
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
            if (rowIndexOfA == -1 || rowIndexOfB == -1)//这两个字符没有在矩阵中找到，则保持原顺序
            {
                result[0] = A;
                result[1] = B;
            }
            else if (rowIndexOfA == rowIndexOfB || colIndexOfA == colIndexOfB)//如果恰好在一行一列，直接互换
            {
                result[0] = B;
                result[1] = A;
            }
            else//如果不在一行或一列，则对角线互换
            {
                result[0] = matrix[rowIndexOfB, colIndexOfA];
                result[1] = matrix[rowIndexOfA, colIndexOfB];
            }
            position.rowIndexOfA = rowIndexOfA;
            position.rowIndexOfB = rowIndexOfB;
            position.colIndexOfA = colIndexOfA;
            position.colIndexOfB = colIndexOfB;
            return result;

        }
        public string EncryptByStep(string orgText, int step, out Position position)
        {            
            char[] result = encrypt2char(orgText, (step-1) * 2, out position);
            return new string(result);
        }
    }
}
