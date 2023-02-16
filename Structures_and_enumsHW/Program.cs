using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
                int size = 0;
                for (int i = 0; num2 != 0; i++)
                {
                    num2 /= 16;
                    size++;
                }
                int[] array = new int[size];

                for (int i = 0; num != 0; i++)
                {
                    array[i] += num % 16;
                    num /= 16;
                }

                string arr = null;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 10)
                    {
                        arr += 'A';
                        continue;
                    }
                    if (array[i] == 11)
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

        public struct RgbColor
        {
            private int red;
            private int green;
            private int blue;

            public RgbColor(int red, int green, int blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
            }

            public string ToHex()
            {
                string hexRed = red.ToString("X2");
                string hexGreen = green.ToString("X2");
                string hexBlue = blue.ToString("X2");
                return $"#{hexRed}{hexGreen}{hexBlue}";
            }

            public (double Hue, double Saturation, double Lightness) ToHsl()
            {
                double r = red / 255.0;
                double g = green / 255.0;
                double b = blue / 255.0;
                double max = Math.Max(r, Math.Max(g, b));
                double min = Math.Min(r, Math.Min(g, b));
                double delta = max - min;
                double hue = 0.0;
                if (delta != 0.0)
                {
                    if (max == r)
                    {
                        hue = ((g - b) / delta) % 6.0;
                    }
                    else if (max == g)
                    {
                        hue = ((b - r) / delta) + 2.0;
                    }
                    else
                    {
                        hue = ((r - g) / delta) + 4.0;
                    }
                    hue *= 60.0;
                    if (hue < 0.0)
                    {
                        hue += 360.0;
                    }
                }
                double lightness = (max + min) / 2.0;
                double saturation = 0.0;
                if (delta != 0.0)
                {
                    saturation = delta / (1.0 - Math.Abs(2.0 * lightness - 1.0));
                }
                return (hue, saturation, lightness);
            }

            public (double Cyan, double Magenta, double Yellow, double Black) ToCmyk()
            {
                double r = red / 255.0;
                double g = green / 255.0;
                double b = blue / 255.0;
                double k = 1.0 - Math.Max(r, Math.Max(g, b));
                double c = (1.0 - r - k) / (1.0 - k);
                double m = (1.0 - g - k) / (1.0 - k);
                double y = (1.0 - b - k) / (1.0 - k);
                return (c, m, y, k);
            }

            public override string ToString()
            {
                return $"RGB ({red}, {green}, {blue})";
            }
        }
                
        static void Main(string[] args)
        {
            //Vector vectorA = new Vector(3, 5, 23);
            //Vector vectorB = new Vector(33, 2, 3);

            //Console.WriteLine(vectorA.Addition(vectorB));
            //Console.WriteLine(vectorA.Subtraction(vectorB));
            //Console.WriteLine(vectorA.MultiNum(4));

            //ProgrammerCalculator programmer = new ProgrammerCalculator(56784);
            //Console.WriteLine(programmer.BinarySystem());
            //Console.WriteLine(programmer.OctalSystem());
            //Console.WriteLine(programmer.HexadecimalSystem());

            RgbColor rgb = new RgbColor(123, 322, 11);
            Console.WriteLine(rgb.ToHex());

            RgbColor rgb1 = new RgbColor(123, 322, 11);
            Console.WriteLine(rgb1.ToCmyk());

            RgbColor rgb2 = new RgbColor(123, 322, 11);
            Console.WriteLine(rgb2.ToHsl());
        }
    }
}
