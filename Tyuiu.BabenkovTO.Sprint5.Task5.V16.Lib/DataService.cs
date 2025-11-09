using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BabenkovTO.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            List<int> del = new List<int>();
            NumberFormatInfo info = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ","
            };
            string text = File.ReadAllText(path);
            string[] strings = text.Split(' ');
            foreach (string s in strings)
            {
                if (int.TryParse(s.Trim(), out int number))
                {
                    if(number != 0 && number % 10 == 0)
                    {
                        del.Add(number);
                    }
                }
            }
            return del.Max();
        }
    }
}
