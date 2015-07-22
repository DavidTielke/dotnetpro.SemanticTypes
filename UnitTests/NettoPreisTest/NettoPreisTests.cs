using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SematicTypes;

namespace UnitTests.NettoPreisTest
{
    [TestClass]
    public partial class NettoPreisTests
    {
        [TestMethod]
        public void Ctor_ValueParameterIs100_ValuePropertyIs100()
        {
            var expected = 100;
            var brutto = new NettoPreis(expected);

            var actual = brutto.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}
