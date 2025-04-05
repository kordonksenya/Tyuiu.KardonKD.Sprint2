using Tyuiu.KardonKD.Sprint2.Task2.V12.Lib;
namespace Tyuiu.KardonKD.Sprint2.Task2.V12.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}