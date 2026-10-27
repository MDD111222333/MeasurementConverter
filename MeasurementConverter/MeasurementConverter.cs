namespace Generics_MeasurementConverter
{
    public class MeasurementConverter
    {
        public static Measurement<TResult> Convert<T, TResult>(
            Measurement<T> source,
            ConverterDelegate<T, TResult> converter,
            string newUnit)
        {
            TResult convertedValue = converter(source.Value);
            return new Measurement<TResult>
            {
                Value = convertedValue,
                Unit = newUnit
            };
        }
    }
}