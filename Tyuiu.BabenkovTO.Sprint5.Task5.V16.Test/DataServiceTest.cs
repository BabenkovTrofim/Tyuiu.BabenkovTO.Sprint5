using Tyuiu.BabenkovTO.Sprint5.Task5.V16.Lib;
namespace Tyuiu.BabenkovTO.Sprint5.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask5V16.txt" });
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}
