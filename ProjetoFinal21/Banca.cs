using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal21
{
    internal class Banca : Jogador

    {
        private int pontos { get; set; }
        private List<Carta> mao;

        public Banca()
        {
            mao = new List<Carta>();
            pontos = 0;
        }

     


    }
}
