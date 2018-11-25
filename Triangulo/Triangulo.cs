using System;
using System.Collections.Generic;
using System.Text;

namespace Objeto
{
    class Triangulo
    {
        int lado1;
        int lado2;
        int lado3;
        string tipo;

        public Triangulo() { }
        public Triangulo(int LADO1, int LADO2, int LADO3)
        {
            this.lado1 = LADO1;
            this.lado2 = LADO2;
            this.lado3 = LADO3;
        }

        public string Avalia()
        {
            
            if ((lado1 == lado2) && (lado3 == lado2))
            {
                tipo = "Triangulo equilatero!";
            }
            else if ((lado1 == lado2) && (lado2 != lado3) || (lado1 != lado2) && (lado2 == lado3) || (lado1!=lado2) && (lado1==lado3))
            {
                tipo = "Triangulo isosceles!";
            }
            else if ((lado1 != lado2) && (lado3 != lado2) && (lado3 != lado1))
            {
                tipo = "Triangulo escaleno!";
            }
            return tipo;
        }
    }
}
