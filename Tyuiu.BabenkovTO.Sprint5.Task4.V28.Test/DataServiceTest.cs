using System.IO;
using Tyuiu.BabenkovTO.Sprint5.Task4.V28.Lib;
namespace Tyuiu.BabenkovTO.Sprint5.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask4V28.txt" });
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}
