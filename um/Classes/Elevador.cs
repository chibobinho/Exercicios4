using System;
namespace um.Classes
{
    public class Elevador
    {
        public int AndarAtual = 0;
        public int Andares;
        public int Capacidade;
        public int PessoasDentro = 0;
        public int AndarDesejado;

        public void Inicializar()
        {
            Console.WriteLine("Quantos andares tem o prédio?");
            Andares = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a capacidade desse elevador?");
            Capacidade = int.Parse(Console.ReadLine());
        }

        public void Subir()
        {
            do
            {
                Console.WriteLine("Para qual andar você quer ir?");
                AndarDesejado = int.Parse(Console.ReadLine());

                if (AndarDesejado < Andares)
                {
                    for (var i = 0; i < AndarDesejado; i++)
                    {
                        AndarAtual = AndarAtual + 1;
                    }
                    Console.WriteLine($"Voce está no andar {AndarAtual}");
                }
                else
                {
                    Console.WriteLine("O número desejado não se encontra.");
                }
            } while (AndarDesejado > Andares);
        }

        public void Descer()
        {
            do
            {
                Console.WriteLine("Para qual andar você quer ir?");
                AndarDesejado = int.Parse(Console.ReadLine());

                if (AndarDesejado > Andares)
                {
                    for (var i = 0; i > AndarDesejado; i++)
                    {
                        AndarAtual = AndarAtual - 1;
                    }
                    Console.WriteLine($"Voce está no andar {AndarAtual}");
                }
                else
                {
                    Console.WriteLine("O número desejado não se encontra.");
                }
            } while (AndarDesejado < Andares);
        }
    }
}

