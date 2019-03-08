using System;
using System.Text;
namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string s = "\u028A - this right here is called Upsilon, my d00ds";
            string r = "C:\\Users\\user\\Documents";
            string f = @"C:\\Users\\user\\Documents";
            string g = @"This aint no \n why isn't new line working\n\n\n?!";
            string e = "\"isto está tudo entre aspas, what shame...\"";
            string t = @"""fogo, isto também está entre aspas? damn, why?""";
            Console.WriteLine("1st string:"+s+"\n2nd string:"+r+"\n3rd string:"+
                f+"\n4th string:"+g+"\n5th string:"+e+"\n6th string:"+t);
            Console.ReadKey();
        }
    }
}
