using System;

namespace SematicTypes
{
    public class MehrwertSteuer : SemanticType<double>
    {
        public MehrwertSteuer(double value) : base(value)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("value","Must be between 0 and 100");
            }
        }

        public override string ToString()
        {
            return Value + " %";
        }

        public static implicit operator MehrwertSteuer(double value)
        {
            return new MehrwertSteuer(value);
        }
    }
}