using System;

namespace projetofinal
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcaoSelecionada = -1;
            exibeMenu();

            do 
            {
                opcaoSelecionada = selecionaOpcao();
                executarOpcao(opcaoSelecionada);
            } while (opcaoSelecionada != 0); 
        }

        static void exibeMenu()
        {
            string menu = @" 
            ================================
            | Menu de opções - Meu projeto |
            ================================
            |  1 - Soma                    |
            |  2 - Subtração               |
            |  3 - Multiplicação           |
            |  4 - Divisão                 |
            |  5 - Exponenciação           | 
            |  6 - Radiciação              |
            |  7 - GrausCF                 |
            |  8 - Sobre                   |
            |  0 - Sair                    |
            ================================";
            Console.WriteLine(menu);
        }
   
        static int selecionaOpcao()
        {
            Console.WriteLine("Digite sua opção: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            var numeroDigitado = keyInfo.KeyChar.ToString();
            if (numeroDigitado == "1" || numeroDigitado == "2" || numeroDigitado == "3" || 
             numeroDigitado == "4" || numeroDigitado == "5" || numeroDigitado == "6" || 
              numeroDigitado == "7" || numeroDigitado == "0" ) 
            {
                return Convert.ToInt32(numeroDigitado);
            }
            else
            {
                return -1;
            }
        }
        
        static void executarOpcao(int opcao)
        {
            switch(opcao)
            {
                case 1:
                    Console.WriteLine("Soma");
                    efetuaSoma();
                    break;
                case 2:
                    Console.WriteLine("Subtração");
                    efetuaSubtracao();
                    break;
                case 3:
                    Console.WriteLine("Multiplicação");
                    efetuaMultiplicacao();
                    break;
                case 4:
                    Console.WriteLine("Divisão");
                    efetuaDivisao();
                    break;
                case 5:
                    Console.WriteLine("Exponenciação");
                    efetuaExponenciacao();
                    break;
                case 6:
                    Console.WriteLine("Radiciação");
                    efetuaRadiciacao();
                    break;
                case 7:
                    Console.WriteLine("GrausCF");
                    efetuaGrausCF();
                    break;
                case 8:
                    Console.WriteLine("Sobre");
                    exibeSobre();
                    break;
                case 0:
                    Console.WriteLine("Muito obrigado por utilizar o programa. Você sempre será bem vindo, então apareça mais vezes!!!");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        private static void efetuaSoma()
        {
           Console.Write("\nDigite um número: ");
           double numeroUm = Convert.ToDouble(Console.ReadLine());
           Console.Write("\nDigite outro número: ");
           double numeroDois = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine($"{numeroUm} + {numeroDois} = {numeroUm + numeroDois}\n");
           Console.WriteLine($"Pressione uma tecla para continuar...");
           Console.ReadKey();
           Console.Clear();  
        }

        private static void efetuaSubtracao()
        {
            Console.Write("\nDigite um número: ");
            double numeroUm = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite outro número: ");
            double numeroDois = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{numeroUm} - {numeroDois} = {numeroUm - numeroDois}\n");
            Console.WriteLine($"Pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void efetuaMultiplicacao()
        {
            Console.Write("\nDigite um número: ");
            double numeroUm = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite outro número: ");
            double numeroDois = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{numeroUm} * {numeroDois} = {numeroUm * numeroDois}\n");
            Console.WriteLine($"Pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
    }

        private static void efetuaDivisao()
        {
            Console.Write("\nDigite um número: ");
            double numeroUm = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite outro número: ");
            double numeroDois = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{numeroUm} / {numeroDois} = {numeroUm / numeroDois}\n");
            Console.WriteLine($"Pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void  efetuaExponenciacao() 
        {

           Console.Write("\nDigite o número da base: ");
           double numeroBase = Convert.ToDouble(Console.ReadLine());
           Console.Write("\nDigite o expoente: ");
           double expoente = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine($"A base {numeroBase} sobre o expoente {expoente} é igual à {Math.Pow(numeroBase,expoente)}"); 
           Console.WriteLine($"Pressione uma tecla para continuar...");
           Console.ReadKey();
           Console.Clear(); 
        }

        private static void  efetuaRadiciacao() 
        {

            Console.Write("\nDigite o número da base: ");
            double numeroBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o expoente: ");
            double indice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A raiz de {numeroBase} com o índice {indice} é igual à {Math.Pow(numeroBase,1/indice)}"); 
            Console.WriteLine($"Pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear(); 
        }

        private static void efetuaGrausCF()
        {
            Console.Write("Digite a temperatura em graus Celsius:");
            double tempC = Convert.ToDouble(Console.ReadLine());
            double tempF = tempC * 1.8 + 32;
            Console.WriteLine($"{tempC}°C equivalente a {tempF}°F");
        }

        private static void exibeSobre()
        {
            Console.WriteLine("Natalie Gonçalves da Silva");
            Console.WriteLine("Etec Adolpho Berezin");
            Console.WriteLine("Programação");
            Console.WriteLine("Repositório: ");
        }
    }
}