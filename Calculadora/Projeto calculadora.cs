using System;

namespace CalculadoraSimples {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Calculadora Simples");
            Console.WriteLine("-------------------");

            while (true) {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");

                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 0)
                    break;

                Console.WriteLine("Digite o primeiro número:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (escolha) {
                    case 1:
                        resultado = Somar(num1, num2);
                        break;
                    case 2:
                        resultado = Subtrair(num1, num2);
                        break;
                    case 3:
                        resultado = Multiplicar(num1, num2);
                        break;
                    case 4:
                        resultado = Dividir(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        continue;
                }

                Console.WriteLine("Resultado: " + resultado);
                Console.WriteLine("-------------------");
            }
        }

        static double Somar(double a, double b) {
            return a + b;
        }

        static double Subtrair(double a, double b) {
            return a - b;
        }

        static double Multiplicar(double a, double b) {
            return a * b;
        }

        static double Dividir(double a, double b) {
            if (b == 0) {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return 0;
            }

            return a / b;
        }
    }
}
