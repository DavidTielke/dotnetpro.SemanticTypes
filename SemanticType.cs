namespace SematicTypes
{
    public abstract class SemanticType<T>
    {
        public T Value { get; protected set; }

        protected SemanticType(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            var other = obj as SemanticType<T>;
            if (other == null)
                return false;
            return other.Value.Equals(Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool operator ==(SemanticType<T> ersterTyp, SemanticType<T> zweiterTyp)
        {
            if (Equals(ersterTyp, null) && Equals(zweiterTyp, null))
            {
                return true;
            }

            if (Equals(ersterTyp, null))
            {
                return false;
            }

            if (Equals(zweiterTyp, null))
            {
                return false;
            }

            return ersterTyp.Equals(zweiterTyp);
        }

        public static bool operator !=(SemanticType<T> ersterTyp, SemanticType<T> zweiterTyp)
        {
            return !(ersterTyp == zweiterTyp);
        }
    }
}