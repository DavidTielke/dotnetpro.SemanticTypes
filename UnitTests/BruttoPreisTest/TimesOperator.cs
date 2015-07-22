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
        public void TimesOp_100BruttoMal2Komma5_250Brutto()
        {
            var multiplikator = 2.5;
            var brutto = new BruttoPreis(100);
            var expected = new BruttoPreis(250);

            var actual = brutto * multiplikator;

            Assert.AreEqual(expected, actual);
        }
    }
}
