using Tyuiu.KardonKD.Sprint2.Task6.V5.Lib;
namespace Tyuiu.KardonKD.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlayingCard()
        {
            DataService ds = new DataService();
            Assert.AreEqual("��������", ds.FindCardValue(6));
            Assert.AreEqual("�������", ds.FindCardValue(7));
            Assert.AreEqual("���������", ds.FindCardValue(8));
            Assert.AreEqual("�������", ds.FindCardValue(9));
            Assert.AreEqual("�������", ds.FindCardValue(10));
            Assert.AreEqual("�����", ds.FindCardValue(11));
            Assert.AreEqual("����", ds.FindCardValue(12));
            Assert.AreEqual("������", ds.FindCardValue(13));
            Assert.AreEqual("���", ds.FindCardValue(14));
        }
    }
}