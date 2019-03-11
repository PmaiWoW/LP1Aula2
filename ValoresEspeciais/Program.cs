using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer:\nMax: " + int.MaxValue + "   Min: "
                + int.MinValue);
            Console.WriteLine("Unsigned Integer:\nMax: " + uint.MaxValue +
                "   Min: " + uint.MinValue);
            Console.WriteLine("Byte:\nMax: " + byte.MaxValue + "   Min: " +
                byte.MinValue);
            Console.WriteLine("SByte:\nMax: " + sbyte.MaxValue + "   Min: " +
                sbyte.MinValue);
            Console.WriteLine("Long:\nMax: " + long.MaxValue + "   Min: " +
                long.MinValue);
            Console.WriteLine("Unsigned Long:\nMax: " + ulong.MaxValue + 
                "   Min: " + ulong.MinValue);
            Console.WriteLine("Short:\nMax: " + short.MaxValue +"   Min: " + 
                short.MinValue);
            Console.WriteLine("Unsigned Short:\nMax: " + ushort.MaxValue +
                "   Min: " + short.MinValue);
            Console.WriteLine("Double:\nMax: " + double.MaxValue + "   Min: "
                + double.MinValue);
            Console.WriteLine("Float:\nMax: " + float.MaxValue + "   Min: " +
                float.MinValue);
            Console.WriteLine("Decimal:\nMax: " + decimal.MaxValue + 
                "   Min: " + decimal.MinValue);
            Console.ReadKey();
        }
    }
}
