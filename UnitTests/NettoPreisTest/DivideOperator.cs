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
        public void DivideOp_100NettoDurch40_2Komma5Netto()
        {
            var divident = 40;
            var brutto = new NettoPreis(100);
            var expected = new NettoPreis(2.5M);

            var actual = brutto/divident;

            Assert.AreEqual(expected, actual);
        }
    }
}
