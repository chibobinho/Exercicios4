using System;
using dois.Classes;

namespace dois
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorDeFutebol j = new JogadorDeFutebol();
            JogadorDefesa d = new JogadorDefesa();
            JogadorMeioCampo m = new JogadorMeioCampo();
            JogadorAtaque a = new JogadorAtaque();

            Console.WriteLine("Qual o nome do jogador?");
            j.Nome = Console.ReadLine();

            Console.WriteLine("Qual o ano de Nascimento do jogador?");
            j.AnoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nacionalidade do jogador?");
            j.Nacionalidade = Console.ReadLine();

            Console.WriteLine("Qual a altura do jogador?");
            j.Altura = Console.ReadLine();

            Console.WriteLine("Qual o peso do jogador?");
            j.Peso = Console.ReadLine();

            Console.WriteLine(j.Imprimir());

            Console.WriteLine(j.Calcular());

            Console.WriteLine("Qual sua posição, defesa, meio ou ataque?");
            string posicao = Console.ReadLine().ToLower();

            switch (posicao)
            {
                case "defesa":
                    Console.WriteLine(j.AposentarDefesa());
                    break;
                case "meio":
                    Console.WriteLine(j.AposentarMeio());
                    break;
                case "ataque":
                    Console.WriteLine(j.AposentarAtaque());
                    break;
                default: 
                    break;
            }
        }
    }
}
