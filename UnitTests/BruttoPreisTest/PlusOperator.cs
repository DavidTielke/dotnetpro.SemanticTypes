using Microsoft.VisualStudio.TestTools.UnitTesting;
using SematicTypes;

namespace UnitTests.BruttoPreisTest
{
    public partial class BruttoPreisTests
    {
        [TestMethod]
        public void Plus_Brutto100PlusBrutto100_Brutto200()
        {
            var brutto1 = new BruttoPreis(100);
            var brutto2 = new BruttoPreis(100);
            var expected = new BruttoPreis(200);

            var result = brutto1 + brutto2;

            Assert.AreEqual(result, expected);
        }
    }
}
