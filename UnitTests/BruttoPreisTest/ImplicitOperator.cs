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
        public void ImplicitDecimal_Assign100M_ValueIs100M()
        {
            var expected = 100M;
            BruttoPreis brutto = expected;

            var actual = brutto.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}
