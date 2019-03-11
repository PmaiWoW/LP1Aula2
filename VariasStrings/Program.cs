using System;
using System.Text;
namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double xx = 0.12345;
            int ii = 18;

            //strings com interpolação e verbatim
            string s = "\u028A - this right here is called Upsilon, my d00ds";
            string s1 = "C:\\Users\\user\\Documents";
            string s2 = @"C:\\Users\\user\\Documents";
            string s3 = @"This aint no \n why isn't new line working\n\n\n?!";
            string s4 = "\"isto está tudo entre aspas, what shame...\"";
            string s5 = @"""fogo, isto também está entre aspas? damn, why?""";
            Console.WriteLine("1st string:"+s+"\n2nd string:"+s1+"\n" +
                "3rd string:"+s2+"\n4th string:"+s3+"\n5th string:"+s4+"\n" +
                "6th string:"+s5+"\n");

            //strings com concatenação
            string r = "Wow " + "These + signs " + "are kinda sticky...";
            string r1 = "why are these numbers sticking to my side?? " + 2351;

            int x = 1;
            int y = 89;
            string r2 = $"{x} is way lower than {y}";
            string r3 = $@"we have the best of both worlds here, {y} is big";

            string r4 = String.Format("{1} < {0}", y, x);
            string r5 = String.Format("the {1} is quite big, at least {0}km " +
                "thicc i say", x, "world");

            Console.WriteLine(r + "\n" + r1 + "\n" + r2 + "\n" + r3 + "\n" + r4
                + "\n" + r5);

            // teste com strings formatadas
            double x1 = 2.5352;
            string t = $"x={x1:f1}";
            Console.WriteLine(t);

            //strings formatadas p/ o exercício 3 da aula 2
            string t1 = $"\nxx Real = {xx:f2}\nxx Percentagem = {xx:p1}";
            Console.WriteLine(t1);

            Console.WriteLine("\nii Hexadec = {0:x}\nii Moeda = {0:c}", ii);
            
            Console.ReadKey();
        }
    }
}
