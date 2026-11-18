using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal21
{
    internal class Jogador
    {

        private List<Carta> mao;
        private int pontos { get; set; }

        public Jogador()
        {
            mao = new List<Carta>();
            pontos = 0;
        }


        public bool VerificaSeEstourou()
        {
            if (pontos > 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AtualizaPontos()
        {
            pontos = 0;
            foreach (Carta c in mao)
            {
                if(c.Valor + pontos >21 && c.Tipo == "A")
                {
                    c.Valor = 1;
                }
                else if (c.Tipo == "A")
                {
                    c.Valor = 11;
                }
                pontos += c.Valor;
            }
        }



        public void pedirCarta(Carta carta)
        {
            mao.Add(carta);
            AtualizaPontos();
        }

        





    }
}
