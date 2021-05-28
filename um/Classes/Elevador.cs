using System;
namespace um.Classes
{
    public abstract class Elevador
    {
        private int andarAtual;
        private int totalAndares;
        private int capacidade;
        private int presentes;
        private int capacidadeCaixas;
        private int presentesCaixas;
        public void Inicializar(int capacidadeTotal, int totalCaixas, int andaresPredio)
        {
            andarAtual = 0;
            presentes = 0;
            totalAndares = andaresPredio;
            capacidadeCaixas = totalCaixas;
            capacidade = capacidadeTotal;


        }
        public void Entrar()
        {
            if (capacidade > presentes)
            {
                presentes = presentes + 1;
                Console.WriteLine("Entrou mais uma pessoa no elevador!");
            }
            else
            {
                Console.WriteLine("O elevador já está lotado!");
            }
        }
        public void Sair()
        {
            if (presentes > 0)
            {
                presentes = presentes - 1;
                Console.WriteLine("Uma pessoa saiu do elevador!");
            }
            else
            {
                Console.WriteLine("Não tem ninguem aqui!");
            }
        }
        public void Subir()
        {
            if (andarAtual < totalAndares)
            {
                andarAtual = andarAtual + 1;
                Console.WriteLine("O elevador subiu um andar.");
            }
            else
            {
                Console.WriteLine("Ta querendo voar mano? Ultimo andar já.");
            }
        }
        public void Subir(int andarDesejado)
        {
            if (andarDesejado >= 0 && andarDesejado <= totalAndares)
            {
                andarAtual = andarDesejado;
                Console.WriteLine($"Fomos para o andar {andarDesejado}");
            }
            else
            {
                Console.WriteLine("Tá maluco, não existe esse andar n fi.");
            }

        }
        public void Descer()
        {
            if (andarAtual > 0)
            {
                andarAtual = andarAtual - 1;
                Console.WriteLine("O elevador desceu um andar.");
            }
            else
            {
                Console.WriteLine("Ta querendo virar topeira? Estamos no terreo.");
            }
        }
        public void EntrarCaixa()
        {
            if (capacidadeCaixas > presentesCaixas)
            {
                presentesCaixas = presentesCaixas + 1;
                Console.WriteLine("Entrou mais uma caixa no elevador!");
            }
            else
            {
                Console.WriteLine("O elevador já está lotado de caixa!");
            }
        }
        public void SairCaixa()
        {
            if (presentesCaixas > 0)
            {
                presentesCaixas = presentesCaixas - 1;
                Console.WriteLine("Uma pessoa caixa foi retirada do elevador!");
            }
            else
            {
                Console.WriteLine("Não tem nenhuma caixa aqui!");
            }
        }
    }
}