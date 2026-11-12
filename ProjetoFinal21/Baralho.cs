using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal21
{
    internal class Baralho
    {

        private List<Carta> cartas;
        private Random rd = new Random();
        private string[] tipos = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        public Baralho()
        {
            cartas = new List<Carta>();
            
           for(int i = 0; i < 4; i++)
            {
                foreach (string t in tipos)
                {
                    Carta c = new Carta(t);
                    cartas.Add(c);
                }
            }
            Embaralhar();



        }

        public void Embaralhar()
        {
            int n = cartas.Count;
            for(int i = 0; i < n; i++)
            {
                int sorteio = rd.Next(0,n);
                Carta copia = cartas[i];
                cartas[i] = cartas[sorteio];
                cartas[sorteio] = copia;
            }
        }

        public Carta RetiraCarta(Carta c)
        {
            // tirar sempre a primeira do baralho igual a um baralho real
            Carta removida = cartas[0];
            cartas.RemoveAt(0);
            return removida;
        }









    }
}
