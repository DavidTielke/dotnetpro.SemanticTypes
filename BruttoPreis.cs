namespace SematicTypes
{
    public class BruttoPreis : SemanticType<decimal>
    {
        public BruttoPreis(decimal value)
            : base(value) 
        {}
        
        public override string ToString()
        {
            return Value.ToString("c");
        }


        public static implicit operator BruttoPreis(decimal value)
        {
            return new BruttoPreis(value);
        }

        public static NettoPreis operator -(BruttoPreis bruttoPreis, MehrwertSteuer vat)
        {
            var netValue = bruttoPreis.Value / (100 + (decimal)vat.Value) * 100;
            return new NettoPreis(netValue);
        }

        public static BruttoPreis operator +(BruttoPreis erstePreis, BruttoPreis zweitePreis)
        {
            var summe = erstePreis.Value + zweitePreis.Value;
            return new BruttoPreis(summe);
        }
        public static BruttoPreis operator -(BruttoPreis erstePreis, BruttoPreis zweitePreis)
        {
            var differenz = erstePreis.Value - zweitePreis.Value;
            return new BruttoPreis(differenz);
        }

        public static BruttoPreis operator /(BruttoPreis preis, double divisor)
        {
            var wertDivision = preis.Value/(decimal)divisor;
            return new BruttoPreis(wertDivision);
        }

        public static BruttoPreis operator *(BruttoPreis preis, double multiplikator)
        {
            var wertMultiplikation = preis.Value*(decimal)multiplikator;
            return new BruttoPreis(wertMultiplikation);
        }
    }
}