using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BabenkovTO.Sprint5.Task7.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            FileInfo file = new FileInfo(path);
            //if (file.Exists == true)
            //{
            //    File.Delete(path);
            //}
            string text = File.ReadAllText(path);
            string newText = text.Replace("н", "нн");
            string newPath = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V18.txt" });
            File.WriteAllText(newPath, newText);
            return newPath;
        }
    }
}
