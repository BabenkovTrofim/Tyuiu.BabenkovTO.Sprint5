using Tyuiu.BabenkovTO.Sprint5.Task7.V18.Lib;
namespace Tyuiu.BabenkovTO.Sprint5.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(new string[] { "C:", "Users", "Trofim", "AppData", "Local", "Temp", "OutPutDataFileTask7V18.txt" });
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}
