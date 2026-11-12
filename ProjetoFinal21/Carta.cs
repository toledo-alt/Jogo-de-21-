using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal21
{
    internal class Carta
    {

        private string tipo;
        private int valor;

        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                if (value >= 1 && value <= 11)
                {
                    valor = value;
                }
                else
                {
                    throw new ArgumentException("Valor inválido para a carta.");
                }
            }


        }

        public string Tipo
        {

            get
            {
                return tipo;
            }

            set
            {
                List<string> valoresValidos = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

                if (valoresValidos.Contains(value))
                {
                    tipo = value;
                }
                else
                {
                    throw new ArgumentException("Valor inválido para a carta.");
                }
            }
        }

        public Carta(string Tipo)
        {
            this.Tipo = Tipo;
            this.Valor = ColocaValor(Tipo);
        }



        int ColocaValor(string tipo)
        {
            if (tipo == "A")
            {
                return 11;
            }
            else if (tipo == "J" || tipo == "Q" || tipo == "K")
            {
                return 10;
            }
            else
            {
                return int.Parse(tipo);


            }






















        }
    }
}

