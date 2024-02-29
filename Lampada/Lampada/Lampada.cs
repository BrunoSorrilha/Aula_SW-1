using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampada
{
    public class Lampada
    {
        private bool Ligada { get; set; } 
        private string? Cor { get; set; }
        private int Potencia { get; set; }

        //Ligar/Desligar
        public void ligar()
        {
            Ligada = true;
        }
        public void desligar()
        {
            Ligada = false;
        }
        public bool estaLigada()
        {
            return Ligada;
        }

        //Definir cor

        public void Colores()
        {
            Cor = "Vermelho";
        }
        public string qualCor()
        {
            return Cor;
        }

        //Potencia da lampada

        public void aopotencia()
        {
            Potencia = 200;
        }
        public int QualPotencia()
        {
            return Potencia;
        }


    }
}
