using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.BabenkovTO.Sprint5.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            for(int x = startValue; x <= stopValue; x++)
            {
                double y;
                if((3 * x + 1.2) != 0)
                {
                    y = ((2 * Math.Sin(x)) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2;
                    y = Math.Round(y, 2);
                }
                else
                {
                    y = 0;
                }
                string strY = Convert.ToString(y);
                if(x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
