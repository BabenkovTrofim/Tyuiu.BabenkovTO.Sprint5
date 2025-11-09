using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BabenkovTO.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            NumberFormatInfo info = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };
            double maxDel = 0;
            string str = File.ReadAllText(path);
            string[] splitStr = str.Split(' ');
            for(int i = 0; i < splitStr.Length; i++)
            {
                double a = double.Parse(splitStr[i], info);
                if((a % 10 == 0) & (a >= maxDel))
                {
                    maxDel = a;
                }
            }
            return Math.Round(maxDel, 3);
        }
    }
}
