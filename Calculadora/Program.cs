using System;
using System.Runtime.Intrinsics;
using System.Transactions;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
           
        }   

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja realizar ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Raiz");
            Console.WriteLine("7 - Sair");
            
            

            Console.WriteLine("---------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma();break;
                case 2: Subtracao();break;
                case 3: Divisao();break;
                case 4: Multiplicacao();break;
                case 5: Potencia();break;
                case 6: Raiz();break;
                case 7: Finalizar();break;
                default: Menu();break;

            }
        }

         static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.ReadKey();
            Menu();
        }      


         static void Subtracao()
        {

            Console.Clear();

            Console.WriteLine("Prmeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");


            double resultado = v1 - v2;
            Console.WriteLine("O resultado da subtração é: " + resultado);
            Console.ReadKey();
            Menu();

        }    


        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 / v2;

            Console.WriteLine("O resultado da divisão é: " + resultado);
            Console.ReadKey();
            Menu();
        }  


        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = v1 * v2;

            Console.WriteLine("O resultado da multiplicação é: " + resultado);
            Console.ReadKey();
            Menu();
        }
          
        static void Potencia()
        {
            Console.Clear();
            Console.WriteLine("Digite a base: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o expoente: ");
            double v2 = double.Parse (Console.ReadLine());

            Console.WriteLine("");
            double resultado = Math.Pow(v1, v2);

            Console.WriteLine("O resultado da potência é: " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Raiz()
        {
            Console.Clear();
            Console.WriteLine("Raiz de um número: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = Math.Sqrt(v1);

            Console.WriteLine("O resultado da raiz quadrada é: " + resultado);
            Console.ReadKey();
            Menu();


        }



        static void Finalizar()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar nosso sistema.");
            System.Environment.Exit(0);


            Console.ReadKey();
            Menu();
        }


    }        
       
}
