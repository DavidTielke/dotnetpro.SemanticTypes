using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.SemanticTypeTest
{
    [TestClass]
    public partial class SemanticTypeTests
    {
        [TestMethod]
        public void Ctor_Initialize100_ValueIs100()
        {
            var expected = 100;
            var type = new SemanticTypeStub(expected);

            var actual = type.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}
