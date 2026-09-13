using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace projeto09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criação do objeto
            Retangulo retangulo = new Retangulo();

            // entrar com os valores de base e altura do retangulo
            retangulo.setN1(entrarInt("Digite o valor de base do retangulo:\n- "));
            retangulo.setN2(entrarInt("Digite o valor de altura do retangulo:\n- "));

            // calcular a área do retangulo
            retangulo.calcular();

            // exibir o resultado da área do retangulo
            Console.WriteLine("A área do retangulo é base {0} x altura {1} = {2}",
                retangulo.getN1(),
                retangulo.getN2(),
                retangulo.getResultado());

            // Verifica se o terreno é grande ou pequeno
            if (retangulo.getResultado() > 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
            {
                Console.WriteLine("Terreno pequeno");
            }
        }
        // Função para entrar com um valor inteiro
        static int entrarInt(string mensagem)
        {
            Console.Write(mensagem);
            return int.Parse(Console.ReadLine());
        }
    }
}        
