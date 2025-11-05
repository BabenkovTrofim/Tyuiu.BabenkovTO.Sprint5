using Tyuiu.BabenkovTO.Sprint5.Task1.V25.Lib;
using System.IO;
namespace Tyuiu.BabenkovTO.Sprint5.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(new string[] { "C:", "Users", "Trofim", "AppData", "Local", "Temp", "OutputFileTask0.txt" });
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
