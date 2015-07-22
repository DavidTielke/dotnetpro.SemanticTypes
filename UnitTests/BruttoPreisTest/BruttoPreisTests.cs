using Microsoft.VisualStudio.TestTools.UnitTesting;
using SematicTypes;

namespace UnitTests.BruttoPreisTest
{
    [TestClass]
    public partial class BruttoPreisTests
    {
        [TestMethod]
        public void Ctor_ValueParameterIs100_ValuePropertyIs100()
        {
            var expected = 100;
            var brutto = new BruttoPreis(expected);

            var actual = brutto.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}
