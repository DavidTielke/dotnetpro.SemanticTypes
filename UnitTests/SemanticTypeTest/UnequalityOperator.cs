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
        public void UnequalityOp_LeftOpIsNull_True()
        {
            Assert.IsTrue(null != new SemanticTypeStub(100));
        }

        [TestMethod]
        public void UnequalityOp_RightOpIsNull_Truee()
        {
            Assert.IsTrue(new SemanticTypeStub(100) != null);
        }

        [TestMethod]
        public void UnequalityOp_100Unequals100_False()
        {
            Assert.IsFalse(new SemanticTypeStub(100) != new SemanticTypeStub(100));
        }
        [TestMethod]
        public void UnequalityOp_100Unequals99_True()
        {
            Assert.IsTrue(new SemanticTypeStub(99) != new SemanticTypeStub(100));
        }
    }
}
