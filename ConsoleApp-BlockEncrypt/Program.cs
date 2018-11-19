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
            Matrix mat = new Matrix();
            mat.GenerateMat();
            mat.PrintMatInConsole();
            char[,] charMat = mat.GetMatrix();
            string org = "hell7do sadf  dasfad dasfasdf";

            BlockEncrypt blockEncrypt = new BlockEncrypt(mat);
            string after = blockEncrypt.Encrypt(org);
            Console.WriteLine(org);
            Console.WriteLine(after);
            string deCrypt = blockEncrypt.Decrypt(after);
            Console.WriteLine(deCrypt);
        }

        
    }
}
