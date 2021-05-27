using System;
namespace tres.Classes
{
    public class MaquinaCafe
    {
        public int AcucarDisponivel;

        public string FazerCafe()
        {
            Console.WriteLine("Quanto de açucar você quer?");
            int acucarSolicitado = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você solicitou {acucarSolicitado}g de açucar");
            if (acucarSolicitado <= AcucarDisponivel)
            {
                Console.WriteLine($"Quantidade de açucar disponivel, café sendo feito com {acucarSolicitado}g");
            }
            else
            {
                Console.WriteLine($"Quantidade de açucar não disponivel, café sendo feito com {AcucarDisponivel}g, que é o que temos :(");
            }
            return "";
        }
    }
}