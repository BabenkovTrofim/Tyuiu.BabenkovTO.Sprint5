using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BabenkovTO.Sprint5.Task4.V28.Lib
{
    public class DataService : ISprint5Task4V28
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            double x = double.Parse(str);
            double y = Math.Round(((3 * Math.Pow(x, 3)) / Math.Sin(x)), 3);
            return y;
        }
    }
}
