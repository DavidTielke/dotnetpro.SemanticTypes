namespace SematicTypes
{
    public class NettoPreis : SemanticType<decimal>
    {
        public NettoPreis(decimal value) : base(value)
        {
        }

        public override string ToString()
        {
            return Value.ToString("c");
        }

        public static implicit operator NettoPreis(decimal value)
        {
            return new NettoPreis(value);
        }

        public static BruttoPreis operator +(NettoPreis nettoPreis, MehrwertSteuer mwst)
        {
            var netValue = nettoPreis.Value + (nettoPreis.Value / 100 * (decimal)mwst.Value);
            return new BruttoPreis(netValue);
        }

        public static NettoPreis operator +(NettoPreis erstePreis, NettoPreis zweitePreis)
        {
            var summe = erstePreis.Value + zweitePreis.Value;
            return new NettoPreis(summe);
        }
        public static NettoPreis operator -(NettoPreis erstePreis, NettoPreis zweitePreis)
        {
            var differenz = erstePreis.Value - zweitePreis.Value;
            return new NettoPreis(differenz);
        }

        public static NettoPreis operator /(NettoPreis preis, double divisor)
        {
            var wertDivision = preis.Value / (decimal)divisor;
            return new NettoPreis(wertDivision);
        }

        public static NettoPreis operator *(NettoPreis preis, double multiplikator)
        {
            var wertMultiplikation = preis.Value * (decimal)multiplikator;
            return new NettoPreis(wertMultiplikation);
        }
    }
}