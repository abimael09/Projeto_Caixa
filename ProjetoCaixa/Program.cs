using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoCaixa
{
    class Program
    {
        static void Main(string[] args)
        {
            Caixa caixa1 = new Caixa();

            Console.WriteLine("\n- Informe a Altura");
            caixa1.altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n- Informe a Largura");
            caixa1.largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n- Informe a Profundidade");
            caixa1.profundidade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("- Calculo do Volume = " + caixa1.calcularVolume());
            Console.WriteLine("\nPressione a Tecla Enter para Sair...");
            Console.ReadKey();
        }
    }
}
