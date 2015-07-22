using Microsoft.VisualStudio.TestTools.UnitTesting;
using SematicTypes;

namespace UnitTests.NettoPreisTest
{
    public partial class NettoPreisTests
    {
        [TestMethod]
        public void Plus_Netto100PlusNetto100_Netto200()
        {
            var netto1 = new NettoPreis(100);
            var netto2 = new NettoPreis(100);
            var expected = new NettoPreis(200);

            var result = netto1 + netto2;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void MinusOp_100NettoPlus19Mwst_119Brutto()
        {
            var netto = new NettoPreis(100);
            var mwst = new MehrwertSteuer(19);
            var expected = new BruttoPreis(119);

            var actual = netto + mwst;

            Assert.AreEqual(expected, actual);
        }
    }
}
