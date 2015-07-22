using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SematicTypes;

namespace UnitTests.NettoPreisTest
{
    public partial class NettoPreisTests
    {
        [TestMethod]
        public void TimesOp_100NettoMal2Komma5_250Netto()
        {
            var multiplikator = 2.5;
            var brutto = new NettoPreis(100);
            var expected = new NettoPreis(250);

            var actual = brutto * multiplikator;

            Assert.AreEqual(expected, actual);
        }
    }
}
