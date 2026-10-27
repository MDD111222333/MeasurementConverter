namespace Generics_MeasurementConverter
{
    public struct Measurement<T>
    {
        public T Value { get; set; }
        public string Unit { get; set; }

        public override string ToString()
        {
            return $"Value = {Value}, Unit = \"{Unit}\"";
        }
    }
}