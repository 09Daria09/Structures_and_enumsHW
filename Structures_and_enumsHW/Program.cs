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
            public Vector(int a,int b,int c)
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
                return (a+vector.a)+(b+vector.b)+(c+vector.c);
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
                string binaryNum = " ";

                while(true)
                {
                    if(num == 0)
                    {
                        break;
                    }
                    binaryNum += num % 2;
                    num /= 2;
                }

                return binaryNum;
            }
        }
        static void Main(string[] args)
        {
            //Vector vectorA = new Vector(3, 5, 23);
            //Vector vectorB = new Vector(33, 2, 3);

            //Console.WriteLine(vectorA.Addition(vectorB));
            //Console.WriteLine(vectorA.Subtraction(vectorB));
            //Console.WriteLine(vectorA.MultiNum(4));

            ProgrammerCalculator programmer = new ProgrammerCalculator(810);
            Console.WriteLine(programmer.BinarySystem());

        }
    }
}
