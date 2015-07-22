using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SematicTypes;

namespace UnitTests.BruttoPreisTest
{
    public partial class BruttoPreisTests
    {
        [TestMethod]
        public void DivideOp_100BruttoDurch40_2Komma5Brutto()
        {
            var divident = 40;
            var brutto = new BruttoPreis(100);
            var expected = new BruttoPreis(2.5M);

            var actual = brutto/divident;

            Assert.AreEqual(expected, actual);
        }
    }
}
