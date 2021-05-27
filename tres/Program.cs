using System;
using tres.Classes;

namespace tres
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe m = new MaquinaCafe();

            Console.WriteLine("Quanto de açucar tem na máquina?");
            m.AcucarDisponivel = int.Parse(Console.ReadLine());

            Console.WriteLine("Você quer açucar no café? (s/n)");
            string opcao = Console.ReadLine().ToLower();
            switch (opcao)
            {
                case "s":
                    Console.WriteLine("Você quer escolher a quantidade? (s/n)");
                    string opcao2 = Console.ReadLine().ToLower();

                    switch (opcao2)
                    {
                        case "s":
                            m.FazerCafe();
                            break;
                        case "n":
                            Console.WriteLine("Ok, por padrão faremos o café com 10g de açucar.");
                            break;
                    }
                    break;
                case "n":
                    Console.WriteLine("Ok, café sendo feito sem açucar");
                    break;
            }
        }
    }
}
