﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio6
{
    internal abstract class Geometria
    {
        public float Largura { get; set; }
        public float Altura { get; set; }

        public virtual float Area()
        {
            return 0;
        }

    }
}
