namespace R_generics
{
    internal class Range<t> where t : IComparable<t>
    {
        public t min { get; }
        public t max { get; }
        public Range(t min, t max)
        {
            if (min.CompareTo(max) > 0) throw new ArgumentException("min can't be greater than max");

            this.min = min;
            this.max = max;
        }
        public bool IsInRange(t val) => val.CompareTo(min) >= 0 && val.CompareTo(max) <= 0;
        public string Lenght() => $"length = {(dynamic)max - (dynamic)min}";
    }
}
