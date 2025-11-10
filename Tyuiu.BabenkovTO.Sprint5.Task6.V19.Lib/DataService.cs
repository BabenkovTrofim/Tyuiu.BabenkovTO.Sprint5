using System.Collections.Specialized;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BabenkovTO.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            string text = File.ReadAllText(path);
            string[] strings = text.Split(' ');
            foreach(string s in strings)
            {
                int countD = 0;
                foreach(char c in s)
                {
                    if (char.IsDigit(c))
                    {
                        countD++;
                    }
                }
                if(countD == s.Length && countD == 2)
                {
                    res++;
                }
            }
            return res;
        }
    }
}
