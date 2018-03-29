﻿namespace Stringify.Converters
{
    public class SingleConverter : DecimalNumberConverter
    {
        internal override object FromString(string value)
        {
            var result = base.FromString(value);
            if (result != null)
                return (float)(int)result;

            return float.Parse(value, Options.NumberStyles, Options.CultureInfo.NumberFormat);
        }

        internal override string ToString(object value, string format)
        {
            return ((float)value).ToString(format, Options.CultureInfo.NumberFormat);
        }
    }
}