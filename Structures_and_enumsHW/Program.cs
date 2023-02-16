using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_and_enumsHW
{
    class Program
    {
        struct Vector
        {
            int a;
            int b;
            int c;
            public Vector(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public int MultiNum(int num)
            {
                return (a * num) + (b * num) + (c * num);
            }
            public int Addition(Vector vector)
            {
                return (a + vector.a) + (b + vector.b) + (c + vector.c);
            }
            public int Subtraction(Vector vector)
            {
                return (a - vector.a) + (b - vector.b) + (c - vector.c);
            }
        }
        struct ProgrammerCalculator
        {
            public int num;
            public ProgrammerCalculator(int num)
            {
                this.num = num;
            }
            public string BinarySystem()
            {
                string binaryNum = null;

                while (true)
                {
                    if (num == 0)
                    {
                        break;
                    }
                    binaryNum += num % 2;
                    num /= 2;
                }

                char[] arr = binaryNum.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }
            public string OctalSystem()
            {
                string binaryNum = null;

                while (true)
                {
                    if (num == 0)
                    {
                        break;
                    }
                    binaryNum += num % 8;
                    num /= 8;
                }

                char[] arr = binaryNum.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }
            public string HexadecimalSystem()
            {
                int num2 = num;
                string UI = num2.ToString();
                int[] array = new int [UI.Length-1];

                for (int i = 0; num != 0; i++)
                {
                    array[i] += num % 16;
                    num /= 16;
                }

                string arr =  null;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 10)
                    {
                        arr += 'A';
                        continue;
                    }
                    if(array[i] == 11)
                    {
                        arr += 'B';
                        continue;
                    }
                    if (array[i] == 12)
                    {
                        arr += 'C';
                        continue;
                    }
                    if (array[i] == 13)
                    {
                        arr += 'D';
                        continue;
                    }
                    if (array[i] == 14)
                    {
                        arr += 'E';
                        continue;
                    }
                    if (array[i] == 15)
                    {
                        arr += 'F';
                        continue;
                    }
                    arr += array[i];
                }

                char[] add = arr.ToCharArray();
                Array.Reverse(add);
                return new string(add);
            }
        }

        static void Main(string[] args)
        {
            //Vector vectorA = new Vector(3, 5, 23);
            //Vector vectorB = new Vector(33, 2, 3);

            //Console.WriteLine(vectorA.Addition(vectorB));
            //Console.WriteLine(vectorA.Subtraction(vectorB));
            //Console.WriteLine(vectorA.MultiNum(4));

            //ProgrammerCalculator programmer = new ProgrammerCalculator(11111);
            //Console.WriteLine(programmer.BinarySystem());
            //Console.WriteLine(programmer.OctalSystem());
            //Console.WriteLine(programmer.HexadecimalSystem());


        }
    }
}
