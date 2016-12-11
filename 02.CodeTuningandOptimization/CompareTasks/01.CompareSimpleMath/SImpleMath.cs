using System;
using System.Diagnostics;

namespace CompareSimpleMath
{
    public class SimpleMath
    {
        private const int IntegerNumber = 1;
        private const long LongNumber = 1L;
        private const float FloatNumber = 1.0F;
        private const double DoubleNumber = 1.0;
        private const decimal DecimalNumber = 1.0m;
        private const int counter = 10000000;

        public static void Add(DataTypeEnum dataType)
        {
            dynamic result = 0;

            switch (dataType)
            {
                case DataTypeEnum.Int:
                    result = IntegerNumber;
                    break;
                case DataTypeEnum.Long:
                    result = LongNumber;
                    break;
                case DataTypeEnum.Float:
                    result = FloatNumber;
                    break;
                case DataTypeEnum.Double:
                    result = DoubleNumber;
                    break;
                case DataTypeEnum.Decimal:
                    result = DecimalNumber;
                    break;
            }
            int addingNumber = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < counter; i++)
            {
                result += addingNumber;
            }
            var elapsedType = stopwatch.Elapsed;
            Console.WriteLine("Time {2} elapsed for Add with {1}: {0}", elapsedType, dataType, result);
        }
    }
}
