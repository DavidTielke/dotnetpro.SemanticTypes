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
        public void GetHashCode_HasFromValue_Euqal()
        {
            var expected = 100;
            var type = new SemanticTypeStub(expected);

            var actual = type.GetHashCode();

            Assert.AreEqual(expected.GetHashCode(), actual);
        }
    }
}
