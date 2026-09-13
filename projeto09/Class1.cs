using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto09
{
    class Retangulo
    {
        // Atributos privados
        private int n1;
        private int n2;
        private int resultado;

        // Set para o primeiro valor
        public void setN1(int valor)
        {
            n1 = valor;
        }

        // Set para o segundo valor
        public void setN2(int valor)
        {
            n2 = valor;
        }

        // Get para o primeiro valor
        public int getN1()
        {
            return n1;
        }

        // Get para o segundo valor
        public int getN2()
        {
            return n2;
        }

        // Get para o resultado
        public int getResultado()
        {
            return resultado;
        }

        // Calcula a área
        public void calcular()
        {
            // base * altura
            resultado = n1 * n2;
        }
    }
}
