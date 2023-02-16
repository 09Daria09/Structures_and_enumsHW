using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_and_enumsHW
{ 
class GFG
    {
        static string decToHexa(int n)
        {
            char[] hexaDeciNum = new char[2];
            int i = 0;
            while (n != 0)
            {
                int temp = 0;
                temp = n % 16;
                if (temp < 10)
                {
                    hexaDeciNum[i] = (char)(temp + 48);
                    i++;
                }
                else
                {
                    hexaDeciNum[i] = (char)(temp + 55);
                    i++;
                }
                n = n / 16;
            }
            string hexCode = "";

            if (i == 2)
            {
                hexCode += hexaDeciNum[0];
                hexCode += hexaDeciNum[1];
            }
            else if (i == 1)
            {
                hexCode = "0";
                hexCode += hexaDeciNum[0];
            }
            else if (i == 0)
                hexCode = "00";
            return hexCode;
        }
        public string convertRGBtoHex(int R, int G, int B)
        {
            if ((R >= 0 && R <= 255) &&
                (G >= 0 && G <= 255) &&
                (B >= 0 && B <= 255))
            {
                string hexCode = "#";
                hexCode += decToHexa(R);
                hexCode += decToHexa(G);
                hexCode += decToHexa(B);

                return hexCode;
            }

            // The hex color code doesn't exist
            else
                return "-1";
        }

        // Driver code
       
    }
}

