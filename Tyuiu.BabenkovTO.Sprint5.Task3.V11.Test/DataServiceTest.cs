using System.IO;
using Tyuiu.BabenkovTO.Sprint5.Task3.V11.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.BabenkovTO.Sprint5.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()           
        {
            string path = Path.Combine(new string[] { "C:", "Users", "Trofim", "AppData", "Local", "Temp", "OutPutFileTask3.bin" });
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}
