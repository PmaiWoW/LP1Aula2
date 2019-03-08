using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variáveis
            string hStr, radStr;
            float h, rad, pi, radPow2, vol, surfArea;
            pi = Convert.ToSingle(Math.PI);

            //Pedir altura do cilindro ao utilizador e converter p/ float
            Console.WriteLine("Input the cilinder's height:");
            hStr = Console.ReadLine();
            h = Convert.ToSingle(hStr);
            //Pedir o raio do cilindro ao utilizador e converter p/ float
            Console.WriteLine("Input the radius of the cilinder");
            radStr = Console.ReadLine();
            rad = Convert.ToSingle(radStr);
            //calcular volume e área da superfície
            radPow2 = Convert.ToSingle(Math.Pow(rad, 2));
            vol = pi * radPow2 * h;
            surfArea = 2 * pi * rad * (rad + h);

            /*Mostrar os resultados ao utilizador(usa duas maneiras diferentes
            para praticar as mesmas, por nenhuma rãzão especial*/
            Console.WriteLine($"Cilinder's Volume = {vol:f3}");
            Console.WriteLine("Cilinder's Surface Area = {0:f3}", 
                surfArea);
            Console.ReadKey();
        }
    }
}
