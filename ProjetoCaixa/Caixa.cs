using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoCaixa
{
    class Caixa
    {
        // Atributos
        public double largura;
        public double altura;
        public double profundidade;

        // Métodos
        public double calcularVolume()
        {
            double volume = (largura * altura * profundidade);
            return volume;
        }
    }
}
