using Tyuiu.KardonKD.Sprint2.Task0.V10.Lib;
namespace Tyuiu.KardonKD.Sprint2.Task0.V10.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1305;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}