using System.IO;
using Tyuiu.BabenkovTO.Sprint5.Task2.V28.Lib;
namespace Tyuiu.BabenkovTO.Sprint5.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.csv" });
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}
