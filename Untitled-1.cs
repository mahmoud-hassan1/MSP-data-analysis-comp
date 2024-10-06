using System;
using System.Collections.Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Untitled-1
           {
            internal class Program
            {
             static void public static void Main(string[] args)
             {
                List<int> mainkey1 = new List<int>() { 1, 3, 4, 2, 5 };
            string plainText = "computerscience";
            string mainCipher3 = "ctipscoeemrnuce".ToUpper();
            string cypherText="";
            int coulmnNum =key.Max();
            double length=plainText.Length;
            int rowsNum = (int)Math.Ceiling(length / coulmnNum);
            char[,] matrix = new char[rowsNum, coulmnNum];
            int x = 0;
            for(int i = 0; i < rowsNum; i++)
            {
                for(int j=0;j< coulmnNum; j++)
                {
                    if (x < plainText.Length)
                    {
                        matrix[i, j] = plainText[x];
                        x++;
                    }
                    else
                    {
                        matrix[i, j] = 'x';
                    }
                }
            }
        
            foreach (int i in key)
            {
                for (int j = 0; j < rowsNum; j++)
                {
                    cypherText += matrix[j,i];
                }
            }
            Console.WriteLine(cypherText);
             }   
            }
           }