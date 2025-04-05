using Tyuiu.KardonKD.Sprint2.Task5V11.Lib;
namespace Tyuiu.KardonKD.Sprint2.Task5V11.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("01.01.2005", ds.FindDateOfNextDay(2004, 12, 31));
        }
    }
}