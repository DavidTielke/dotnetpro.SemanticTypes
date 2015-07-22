using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SematicTypes;

namespace UnitTests.SemanticTypeTest
{
    class SemanticTypeStub : SemanticType<int>
    {
        public SemanticTypeStub(int value) : base(value)
        {
        }
    }
}
