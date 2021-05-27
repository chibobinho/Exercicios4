using System;
using um.Classes;

namespace um
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador e = new Elevador();

            e.Inicializar();
            do
            {
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine($@"
1 - Subir
2 - Descer
            ");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        e.Subir();
                        break;
                    case "2":
                        e.Descer();
                        break;
                    default:
                        break;
                }
            } while (true);


        }
    }
}
