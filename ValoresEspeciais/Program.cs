using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer:\nMax: " + int.MaxValue + "   Min: "
                + int.MinValue + "\nUnsigned Integer:\nMax: " + uint.MaxValue +
                "   Min: " + uint.MinValue);
            Console.WriteLine("\nByte:\nMax: " + byte.MaxValue + "   Min: " +
                byte.MinValue + "\nSByte:\nMax: " + sbyte.MaxValue + 
                "   Min: " + sbyte.MinValue);
            Console.WriteLine("\nLong:\nMax: " + long.MaxValue + "   Min: " +
                long.MinValue + "\nUnsigned Long:\nMax: " + ulong.MaxValue + 
                "   Min: " + ulong.MinValue);
            Console.WriteLine("\nShort:\nMax: " + short.MaxValue +"   Min: " + 
                short.MinValue + "\nUnsigned Short:\nMax: " + ushort.MaxValue +
                "   Min: " + short.MinValue);
            Console.WriteLine("\nDouble:\nMax: " + double.MaxValue + "   Min: "
                + double.MinValue + "\nFloat:\nMax: " + float.MaxValue + 
                "   Min: " + float.MinValue + "\nDecimal:\nMax: " + 
                decimal.MaxValue + "   Min: " + decimal.MinValue);

            //Infinites & NaN (Float)
            Console.WriteLine("\nPositive Infinite(Float): " + 
                float.PositiveInfinity + "Negative Infinite(Float): " + 
                float.NegativeInfinity);
            Console.WriteLine("Nan(Float): " + float.NaN);
            //Infinites & NaN (Double)
            Console.WriteLine("\nPositive Infinite(Double): " +
                double.PositiveInfinity + "\nNegative Infinite(Double): " +
                double.NegativeInfinity);
            Console.WriteLine("NaN(Double): " + 
                (double.PositiveInfinity / double.PositiveInfinity));

            //Criar variáveis contendo os valores máximos
            //Testar e fazer print de overflows em tipos inteiros
            short i1 = short.MaxValue;
            long i2 = long.MaxValue;
            sbyte i3 = sbyte.MaxValue;
            int i4 = int.MaxValue;
            byte i5 = byte.MaxValue;
            ushort i6 = ushort.MaxValue;
            uint i7 = uint.MaxValue;
            ulong i8 = ulong.MaxValue;

            Console.WriteLine("\nOverflow(Short): " + (short) (i1 + 1));
            Console.WriteLine("Overflow(Long): " + (i2 + 1));
            Console.WriteLine("Overflow(sByte): " + (sbyte)(i3 + 1));
            Console.WriteLine("Overflow(Int): " + (i4 + 1));
            Console.WriteLine("Overflow(Byte): " + (byte)(i5 + 1));
            Console.WriteLine("Overflow(uShort): " + (ushort)(i6 + 1));
            Console.WriteLine("Overflow(uInt): " + (uint)(i7 + 1));
            Console.WriteLine("Overflow(uLong): " + (ulong)(i8 + 1));

            Console.ReadKey();
        }
    }
}
