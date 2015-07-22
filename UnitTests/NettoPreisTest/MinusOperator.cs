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
        public void MinusOp_100NettoMinus50Netto_50Netto()
        {
            var brutto1 = new NettoPreis(100);
            var brutto2 = new NettoPreis(50);
            var expected = new NettoPreis(50);

            var actual = brutto1 - brutto2;

            Assert.AreEqual(expected, actual);
        }
    }
}
