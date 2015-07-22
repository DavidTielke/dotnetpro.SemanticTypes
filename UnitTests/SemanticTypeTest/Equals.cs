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
        public void Equals_EqualsNull_False()
        {
            var type = new SemanticTypeStub(100);

            Assert.IsFalse(type.Equals(null));
        }

        [TestMethod]
        public void Equals_AnotherDatatype_False()
        {
            var type = new SemanticTypeStub(100);

            Assert.IsFalse(type.Equals(new object()));
        }

        [TestMethod]
        public void Equals_100Equals100_True()
        {
            var type1 = new SemanticTypeStub(100);
            var type2 = new SemanticTypeStub(100);

            Assert.IsTrue(type1.Equals(type2));
        }

        [TestMethod]
        public void Equals_100Equals99_False()
        {
            var type1 = new SemanticTypeStub(100);
            var type2 = new SemanticTypeStub(99);

            Assert.IsFalse(type1.Equals(type2));
        }
    }
}
