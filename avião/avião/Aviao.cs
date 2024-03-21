using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avião
{
     class Aviao
    {
        private float Velocidade { get; set; }
        private float Altura { get; set; }

        public float Altura_Atual()
        {
            return Altura;
        }
        public float Velocidade_Atual()
        {
            return Velocidade;
        }
        public float Vrumm(float mudar_altura)
        {
            Altura += mudar_altura;
            return Altura_Atual();
        }
        public float Ziumm(float marcos)
        {
            Velocidade += marcos;
            return Velocidade_Atual();
        }
    }
}
