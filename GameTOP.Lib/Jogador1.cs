
using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _nome;
    
        public Jogador1(string nome = "Ronaldo")
        {
            _nome = nome;
        }

        public string Chuta()
        {
            return $"{_nome} está Chutando \n";
        }

        public string Corre()
        {
            return $"{_nome} está Correndo \n";
        }

        public string Passe()
        {
            return $"{_nome} está Passando \n";
        }
    }
}