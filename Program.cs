using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("Informe a cotação do Dolar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine());

                if (cotacaoDolar <= 0)
                {
                    Console.WriteLine("Informe um valor maior do que 0 (Zero)");
                    Console.WriteLine("Programa Encerrado.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Informe a cotação do Euro: ");
                    double cotacaoEuro = double.Parse(Console.ReadLine());

                    if (cotacaoEuro <= 0)
                    {
                        Console.WriteLine("Informe um valor maior do que 0 (Zero)");
                        Console.WriteLine("Programa Encerrado.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Write("Informe a cotaçao do Ouro: ");
                        double cotacaoOuro = double.Parse(Console.ReadLine());

                        if (cotacaoOuro <=0 )
                        {
                            Console.WriteLine("Informe um valor maior do que 0 (Zero)");
                            Console.WriteLine("Programa Encerrado.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Write("Informe o valor a ser investido: ");
                            double valorInvestido = double.Parse(Console.ReadLine());

                            if (valorInvestido <= 0)
                            {
                                Console.WriteLine("Informe um valor maior do que 0 (Zero)");
                                Console.WriteLine("Programa Encerrado.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                double investDolar = valorInvestido;
                                double investEuro = valorInvestido;
                                double investOuro = valorInvestido;

                                double valorDolar = investDolar / cotacaoDolar;
                                double valorEuro = investEuro / cotacaoEuro;
                                double valorOuro = investOuro / cotacaoOuro;

                                Console.WriteLine("\nValor em Dólar: $" + valorDolar);
                                Console.WriteLine("\nValor em Euro: $" + valorEuro);
                                Console.WriteLine("\nValor em Ouro: $" + valorOuro);
                            }
                        }
                    }
                }               

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Insira apenas números");
            }
            finally
            {
                Console.WriteLine("Programa Finalizado.");
                    Console.ReadKey();
            }
        }
    }
}
