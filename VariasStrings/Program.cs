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
            Console.WriteLine("1st string:"+s+"\n2nd string:"+r+"\n3rd string:"
                +f+"\n4th string:"+g+"\n5th string:"+e+"\n6th string:"+t);

            string x = "Wow " + "These + signs " + "are kinda sticky...";
            string y = "why are these numbers sticking to my side??" + 223551;

            int p = 23;
            int l = 89;
            string z = $"{p} is way lower than {l}";
            string c = $@"we have the best of both worlds here, {l} is big";

            string m = String.Format("{1} > {0}", p, l);
            string n = String.Format("the {1} is quite big, at least {0}km " +
                "thicc i say", 1, "world");

            Console.WriteLine(x + "\n" + y + "\n" + z + "\n" + c + "\n" + m + 
                "\n" + n);
            Console.ReadKey();
        }
    }
}
