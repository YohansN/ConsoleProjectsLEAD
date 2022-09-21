using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio6
{
    internal class Triangulo : Geometria
    {
        public override float Area()
        {
            return (Largura * Largura) / 2;
        }

        public Triangulo(float altura, float largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }
    }
}
