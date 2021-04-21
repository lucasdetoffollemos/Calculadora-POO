using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c1 = new Calculadora();
            int cont = 0;
            while (true)
            {
                c1.MostraMenu();

                c1.operacao = Console.ReadLine();
                Console.Clear();

                if (c1.operacao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (c1.operacao == "5")
                {
                    c1.MostraResultados();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (c1.VerificaOpcaoInvalida(c1.operacao))
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("Digite o primeiro numero: ");
                c1.numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero: ");
                c1.numero2 = Convert.ToDouble(Console.ReadLine());

                if(c1.operacao == "4" && c1.numero2 == 0){
                    Console.WriteLine("Não é possível dividir um número por zero.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                double resultado = 0;

                resultado = c1.RealizaCalculo(c1.operacao, c1.numero1, c1.numero2);

                c1.MostraSimboloOperacao(c1.operacao);

                string mostraResultado = $"Resultado de {c1.numero1} {c1.operacao} {c1.numero2} =  {resultado}";

                c1.AdicionaArrayResultados(mostraResultado, cont);
                cont++;

                Console.WriteLine(mostraResultado);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
