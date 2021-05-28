using System;
using um.Classes;

namespace um
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            Console.WriteLine("Exercicio do elevador");

            ElevadorSocial so = new ElevadorSocial();
            ElevadorServico se = new ElevadorServico();

            so.Inicializar(4, 4, 5);

            do
            {
                Console.WriteLine($@"
Qual operação deseja realizar?
1 - Subir
2 - Descer
3 - Entrar
4 - Sair
5 - Colocar caixa
6 - Tirar caixa
99 - Sair do programa
");

                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        Console.WriteLine("Você deseja escolher o número do andar? (s/n)");
                        string respostaAndar = Console.ReadLine().ToLower();

                        if (respostaAndar == "s")
                        {
                            Console.WriteLine("Qual andar você deseja?");
                            int andarEscolhido = int.Parse(Console.ReadLine());

                            so.Subir(andarEscolhido);
                        }
                        else
                        {
                            so.Subir();
                        }
                        break;
                    case "2":
                        so.Descer();
                        break;
                    case "3":
                        so.Entrar();
                        break;
                    case "4":
                        so.Sair();
                        break;
                    case "5":
                        so.EntrarCaixa();
                        break;
                    case "6":
                        so.SairCaixa();
                        break;
                    default:
                        break;
                }
            } while (resposta != "99");
        }
    }
}
