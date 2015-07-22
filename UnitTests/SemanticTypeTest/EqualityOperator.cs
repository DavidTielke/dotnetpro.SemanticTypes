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
        public void EqualityOp_LeftOpIsNull_False()
        {
            Assert.IsFalse(null == new SemanticTypeStub(100));
        }

        [TestMethod]
        public void EqualityOp_RightOpIsNull_False()
        {
            Assert.IsFalse(new SemanticTypeStub(100) == null);
        }

        [TestMethod]
        public void EqualityOp_100Equals100_True()
        {
            Assert.IsTrue(new SemanticTypeStub(100) == new SemanticTypeStub(100));
        }
        [TestMethod]
        public void EqualityOp_100Equals99_False()
        {
            Assert.IsFalse(new SemanticTypeStub(99) == new SemanticTypeStub(100));
        }
    }
}
