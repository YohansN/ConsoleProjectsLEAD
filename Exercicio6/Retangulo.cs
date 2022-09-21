using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio6
{
    internal class Retangulo : Geometria
    {
        public  override float Area()
        {
            return Largura * Altura;
        }

        public Retangulo(float altura, float largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }
    }
}
