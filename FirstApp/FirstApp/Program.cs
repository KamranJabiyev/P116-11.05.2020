using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DataType
            //var a = 5;
            //int a = 5;
            //a = 10;
            //int b = 15;
            //string word = "Hello";
            //char letter = 'a';
            //bool isMaried = true;

            //decimal p = 3.14m;
            //float f = 1.1F;
            //double x = 5.15;

            //// Camel , Paskal , undercase , kebabcase

            //string FullName="Kamran Jabiyev";

            //Console.WriteLine();
            //Console.Read();
            #endregion

            #region Loops
            int[] arr = { 5,15,100};
            string[] stuName = { "Tural", "Hesen", "Kerim","Ferid" };
            //Console.WriteLine(stuName.Length);
            //Console.WriteLine(stuName[0]);
            //Console.WriteLine(stuName[1]);
            //Console.WriteLine(stuName[2]);
            //Console.WriteLine(stuName[3]);
            //Loops
            //foreach (string test in stuName)
            //{
            //    Console.WriteLine(test);
            //}
            //for (int i = 0; i < stuName.Length; i++)
            //{
            //    Console.WriteLine(stuName[i]);
            //}
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);

            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Switch case
            int age = 14;
            //Switch case
            switch (age)
            {
                case 18:
                    Console.WriteLine("Yashi "+age);
                    break;
                case 15:
                    Console.WriteLine("Yashi " + age);
                    break;
                default:
                    Console.WriteLine("Odenilmir");
                    break;
            }
            #endregion

            #region Conditions
            //Conditions
            //string result = (age > 18) ? "Xosh gelmishsiniz" : "Yashiniz chatmir";
            //Console.WriteLine(result);

            //if (age>18)
            //{
            //    Console.WriteLine("Xosh gelmishsiniz");
            //}
            //else if (age == 18)
            //{
            //    Console.WriteLine("Az qalib");
            //}
            //else
            //{
            //    Console.WriteLine("Yashiniz chatmir");
            //}
            #endregion
        }
    }
}
