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
        public void MinusOp_100BruttoMinus50Brutto_50Brutto()
        {
            var brutto1 = new BruttoPreis(100);
            var brutto2 = new BruttoPreis(50);
            var expected = new BruttoPreis(50);

            var actual = brutto1 - brutto2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOp_119BruttoMinus19Mwst_100Netto()
        {
            var brutto = new BruttoPreis(119);
            var mwst = new MehrwertSteuer(19);
            var expected = new NettoPreis(100);

            var actual = brutto - mwst;

            Assert.AreEqual(expected, actual);
        }
    }
}
