using System;

namespace ClassLibrary1
{
    public class Converter
    {
        static public string ToRoman(int i)
        {
            string[] valori = { "I", "V", "X", "L", "C", "D", "M" };
            string s = "";
            int y;
            if (i >= 1000)
            {
                y = i / 1000;
                s += ConvertitoreU(y, valori[6], " ", " ");
                i %= 1000;
            }
            if (i >= 100)
            {
                y = i / 100;
                s += ConvertitoreU(y, valori[4], valori[5], valori[6]);
                i %= 100;
            }
            if (i >= 10)
            {
                y = i / 10;
                s += ConvertitoreU(y, valori[2], valori[3], valori[4]);
                i %= 10;
            }
            y = i;
            s += ConvertitoreU(y, valori[0], valori[1], valori[2]);
            return s;
        }

        static public string ConvertitoreU(int y ,string a, string b, string c)
        {
            string s = "";
            switch (y)
            {
                case 1:
                    s = a;
                    break;
                case 2:
                    s = a+a;
                    break;
                case 3:
                    s = a+a+a;
                    break;
                case 4:
                    s = a+b;
                    break;
                case 5:
                    s = b;
                    break;
                case 6:
                    s = b+a;
                    break;
                case 7:
                    s = b+a+a;
                    break;
                case 8:
                    s = b+a+a+a;
                    break;
                case 9:
                    s = a+c;
                    break;
            }
            return s;
        }
    }
}