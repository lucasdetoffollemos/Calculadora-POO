using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraApp
{
    class Calculadora
    {
        public double numero1, numero2;
        public string operacao;
        public string [] resultados = new string [100];

        public void MostraMenu()
        {
            Console.WriteLine("Calculadora ");
            Console.WriteLine("Digite 1 para somar: ");
            Console.WriteLine("Digite 2 para subtrair: ");
            Console.WriteLine("Digite 3 para multiplicar: ");
            Console.WriteLine("Digite 4 para dividir: ");
            Console.WriteLine("Digite 5 para ver as operações: ");
            Console.WriteLine("Digite S para sair: ");
        }

        public bool VerificaOpcaoInvalida(string opcao)
        {
            bool opcaoInvalida = opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "s" && opcao != "S";
            return opcaoInvalida;
        }

        public void MostraSimboloOperacao(string op)
        {
            if(op == "1")
                operacao = "+";
            
            else if (op == "2")
                operacao = "-";
            
            else if (op == "3")
                operacao = "*";
         
            else if (op == "4")
                operacao = "/";
        }

        public double RealizaCalculo(string op, double n1, double n2)
        {
            double resultado = 0;

            switch (op)
            {
                case "1":
                    resultado = n1 + n2;
                    break;
                case "2":
                    resultado = n1 - n2;
                    break;
                case "3":
                    resultado = n1 * n2;
                    break;
                case "4":
                    resultado = n1 / n2;
                    break;
                default: break;
            }

            return resultado;
        }

        public void MostraResultados()
        {
            for(int i = 0; i< resultados.Length; i++)
            {
                if(resultados[i] != null)
                {
                    Console.WriteLine(resultados[i]);
                }
                
            }
        }

        public string [] AdicionaArrayResultados(string resultado, int cont)
        {
            resultados[cont] = resultado;

            return resultados;
        }

    }
}
