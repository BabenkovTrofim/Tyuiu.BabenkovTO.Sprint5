using Tyuiu.BabenkovTO.Sprint5.Task0.V16.Lib;
namespace Tyuiu.BabenkovTO.Sprint5.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] path = { @"C:\Users", "Trofim", "source", "repos", "Tyuiu.BabenkovTO.Sprint5", "Tyuiu.BabenkovTO.Sprint5.Task0.V16", "bin", "Debug", "net8.0", "OutPutFileTask0.txt" };
            string fullPath = Path.Combine(path);
            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
