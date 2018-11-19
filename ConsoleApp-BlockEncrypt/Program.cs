using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_BlockEncrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] charMat = GenerateMat();
            PrintMat(charMat);
            string org = "hell7do sadf  dasfad dasfasdf";
            string after = encrypt(org, charMat);
            Console.WriteLine(org);
            Console.WriteLine(after);
            string deCrypt = encrypt(after, charMat);
            Console.WriteLine(deCrypt);
        }

        static string encrypt(string orgText, char[,] mat)
        {
            StringBuilder afterText = new StringBuilder();
            int length = orgText.Length;
            if (length % 2 == 1)
            {
                length -= 1;
            }
            for (int i = 0; i < length; i += 2)
            {
                afterText.Append(encrypt2char(orgText, i, mat));
            }
            if (length != orgText.Length)
            {
                afterText.Append(orgText.ToArray()[length]);
            }
            return afterText.ToString();
        }
        static char[] encrypt2char(string orgText, int startIndex, char[,] matrix)
        {
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

        static void PrintArray(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
        static void PrintMat(char[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j]);
                }
                Console.WriteLine();
            }
        }
        static char[,] GenerateMat()
        {
            char[] charList = new char[96];
            for (int i = 0; i < charList.Length; i++)
            {
                charList[i] = Convert.ToChar(i + 32);
            }
            Shuffle(charList);
            char[,] result = new char[8, 12];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    result[i, j] = charList[i * 12 + j];
                }
            }
            return result;
        }
        static void Shuffle(char[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                Random rand = new Random();
                int p = rand.Next(i);
                char temp = array[p];
                array[p] = array[i];
                array[i] = temp;
            }
        }
    }
}
