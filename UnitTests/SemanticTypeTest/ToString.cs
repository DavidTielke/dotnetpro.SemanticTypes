using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.SemanticTypeTest
{
    public partial class SemanticTypeTests
    {
        [TestMethod]
        public void ToString_ValueIs199_String119Returned()
        {
            var expected = 119;
            var type = new SemanticTypeStub(expected);

            var actual = type.ToString();

            Assert.AreEqual(expected.ToString(), actual);
        }
    }
}
