using System.IO;
using Tyuiu.BabenkovTO.Sprint5.Task6.V19.Lib;
namespace Tyuiu.BabenkovTO.Sprint5.Task6.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask6V19.txt" });
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}
