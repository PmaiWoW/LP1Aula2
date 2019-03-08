using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variáveis
            string hStr, radStr;
            float h, rad, vol, surfArea;
            float pi = 3.1415926f;

            //Pedir altura do cilindro ao utilizador e converter p/ float
            Console.WriteLine("Input the cilinder's height:");
            hStr = Console.ReadLine();
            h = Convert.ToSingle(hStr);
            //Pedir o raio do cilindro ao utilizador e converter p/ float
            Console.WriteLine("Input the radius of the cilinder");
            radStr = Console.ReadLine();
            rad = Convert.ToSingle(radStr);
            //calcular volume e área da superfície
            vol = pi * (rad*rad) * h;
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
