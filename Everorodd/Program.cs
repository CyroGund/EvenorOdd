using System;

namespace Everorodd
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int NumeroDigitado;
            Console.WriteLine("Insira Um Numero:"); // Exibe a Mensagem 
                   NumeroDigitado = Convert.ToInt32(Console.ReadLine()); //Lê e converte para int o número informado pelo usuário
            if ( NumeroDigitado % 2 == 0)
            {
                //Numero Par
                Console.WriteLine("Par");
            }
            else
            {
                //Numero Impar
                Console.WriteLine("Impar");
            }
            Console.ReadKey();
        }
    }
}
