using System;
namespace dois.Classes
{
    public class JogadorDeFutebol
    {
        public string Nome;
        public int AnoNascimento;
        public string Nacionalidade;
        public string Altura;
        public string Peso;
        public int idade;

        public string Imprimir()
        {
            Console.WriteLine($@"
Nome: {Nome}
Data de Nascimento: {AnoNascimento} 
Nacionalidade: {Nacionalidade}
Altura: {Altura}
Peso: {Peso}           
");
            return "Imprimindo dados...";
        }
        public string Calcular()
        {
            idade = 2021 - AnoNascimento;
            return $"A idade do jogador é de {idade} anos";
        }
        public string AposentarDefesa()
        {
            int idadeAposentar = 40 - idade;
            return $"O jogador se aposentará aproximadamente em {idadeAposentar} anos.";
        }
        public string AposentarMeio()
        {
            int idadeAposentar = 38 - idade;
            return $"O jogador se aposentará aproximadamente em {idadeAposentar} anos.";
        }
        public string AposentarAtaque()
        {
            int idadeAposentar = 35 - idade;
            return $"O jogador se aposentará aproximadamente em {idadeAposentar} anos.";
        }
    }
}