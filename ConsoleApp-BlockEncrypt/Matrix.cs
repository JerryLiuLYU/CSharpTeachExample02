using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_BlockEncrypt
{
    [Serializable]
    public class Matrix
    {
        private char[,] charMat;

        public char[,] GetMatrix()
        {
            if (charMat !=null)
            {
                return charMat;
            }
            return null;
        }

        public void PrintMatInConsole()
        {
            if (charMat != null)
            {
                for (int i = 0; i < charMat.GetLength(0); i++)
                {
                    for (int j = 0; j < charMat.GetLength(1); j++)
                    {
                        Console.Write(charMat[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write("矩阵为空");
            }
           
        }

        public void GenerateMat()
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
            charMat = result;
        }


        private void Shuffle(char[] array)
        {
            Random rand = new Random();
            for (int i = array.Length-1 ; i > 0; i--)
            {                
                int p = rand.Next(i);
                char temp = array[p];
                array[p] = array[i];
                array[i] = temp;
            }
        }
    }
}
