using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    public delegate double MinFunc(double x);
    class MinFun
    {
        
        public static void SaveFunc(string fileName, MinFunc _F, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(_F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static List<double> Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            List<double> arr = new List<double>();
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {

                d = bw.ReadDouble();
                arr.Add(d);
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return arr;
        }
    }
}
