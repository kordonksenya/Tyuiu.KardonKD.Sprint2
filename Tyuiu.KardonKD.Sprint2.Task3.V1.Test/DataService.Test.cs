using Tyuiu.KardonKD.Sprint2.Task3.V1.Lib;
namespace Tyuiu.KardonKD.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();

            double x = 5;

            var res = ds.Calculate(x);
            Assert.AreEqual(88.697, res);
        }
    }
}