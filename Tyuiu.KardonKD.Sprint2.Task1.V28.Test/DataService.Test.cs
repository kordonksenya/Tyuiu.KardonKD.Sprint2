using Tyuiu.KardonKD.Sprint2.Task1.V28.Lib;
namespace Tyuiu.KardonKD.Sprint2.Task1.V28.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetLogicOperationsTest()
        {
            DataService ds = new DataService();
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            int a = 247, b = 654, c = 671, d = 671;
            CollectionAssert.AreEqual(wait, ds.GetLogicOperations(a, b, c, d));
        }
    }
}