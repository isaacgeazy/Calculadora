using System;

namespace projetin
{
    class Program
    {
        static void Main(string[] args)
         {             
              ExibirMenu(); 

              string op = "";
      
              Console.Write("  Opção.: ");
              op = Console.ReadLine();
              Console.WriteLine();
             
              switch (op)
              {
                case "1":
                Opcao1();
                  break;
              
                case "2":
                Opcao2();
                break;

                case "3":
                Opcao3();
                break;

                case "4":
                Opcao4();
                break;

                case "5":
                Opcao5();
                break;

                case "6":
                Opcao6();
                break;

                case "7":
                Opcao7();
                break;

                case "8":
                Opcao8();
                break;

                case "0":
                Opcao0();
                break;

                default:     
                Console.WriteLine();          
                Console.WriteLine("  Opção inválida!");
                Console.ReadKey();
                Console.Clear();
                ExibirMenu();
                Opcoes();
                 break;               
            
              }
             
        }
  static void ExibirMenu()
        {            
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine("         CALCULADORA BÁSICA        ");
          Console.ResetColor();
                   
                   Console.ForegroundColor = ConsoleColor.Magenta;
                   Console.WriteLine(" __________________________________ ");   
                   Console.ResetColor();                               
                   Console.WriteLine();
                   Console.ForegroundColor = ConsoleColor.Gray;
                   Console.WriteLine("  [1]- Soma ");   
                   Console.WriteLine("  [2]- Subtração ");    
                   Console.WriteLine("  [3]- Multiplicação ");  
                   Console.WriteLine("  [4]- Divisão ");  
                   Console.WriteLine("  [5]- Exponenciação ");    
                   Console.WriteLine("  [6]- Radiciação (RAÍZ QUADRADA) ");   
                   Console.WriteLine("  [7]- Bhaskara ");    
                   Console.WriteLine();
                   Console.WriteLine("  [8]- Créditos ");  
                   Console.WriteLine("  [0]- Sair"); 
                   Console.ResetColor();
                   Console.WriteLine();             
                   Console.ForegroundColor = ConsoleColor.Magenta;                      
                   Console.WriteLine(" __________________________________ ");
                   Console.ResetColor(); 
                   Console.WriteLine();
                                        
            }
  static void Opcao1() 
            {   
              Console.Clear();  
              
              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.WriteLine("        - SOMA -        ");
              Console.ResetColor();
              Console.WriteLine();
              
              Console.Write("Digite o PRIMEIRO número..: ");
               int n1 = int.Parse(Console.ReadLine());

              Console.Write("Digite o SEGUNDO número..: ");
               int n2 = int.Parse(Console.ReadLine());
 
               int resu = n1 + n2;

              Console.WriteLine();
              Console.WriteLine($"A SOMA entre os números {n1} e {n2} é {resu}");

              Console.WriteLine();             
              voltarMenu();




              }   
  static void Opcao2()
         {
              Console.Clear();  
              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.WriteLine("        - SUBTRAÇÃO -       ");
              Console.ResetColor();

              Console.WriteLine();
              
              Console.Write("Digite o PRIMEIRO número..: ");
               int n1 = int.Parse(Console.ReadLine());

              Console.Write("Digite o SEGUNDO número..: ");
               int n2 = int.Parse(Console.ReadLine());
 
               int resu = n1 - n2;

                Console.WriteLine();
              Console.WriteLine($"A SUBTRAÇÃO entre os números {n1} e {n2} é {resu}");

              Console.WriteLine();
              voltarMenu();

        
         }
  static void Opcao3()
         {
             Console.Clear();  
              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.WriteLine("        MULTIPLICAÇÃO        ");
              Console.ResetColor();
                Console.WriteLine();
              
              Console.Write("Digite o PRIMEIRO número..: ");
               int n1 = int.Parse(Console.ReadLine());

              Console.Write("Digite o SEGUNDO número..: ");
               int n2 = int.Parse(Console.ReadLine());
 
               int resu = n1 * n2;

                Console.WriteLine();
              Console.WriteLine($"A MULTIPLICAÇÃO entre os números {n1} e {n2} é {resu}");

              Console.WriteLine();
              voltarMenu();

         }
  static void Opcao4() 
         {
              Console.Clear();  
              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.WriteLine("        - DIVISÃO -        ");
              Console.ResetColor();
              Console.WriteLine();
              
              Console.Write("Digite o PRIMEIRO número..: ");
               int n1 = int.Parse(Console.ReadLine());

              Console.Write("Digite o SEGUNDO número..: ");
               int n2 = int.Parse(Console.ReadLine());
 
               int resu = n1 / n2;

              Console.WriteLine();
              Console.WriteLine($"A DIVISÃO entre os números {n1} e {n2} é {resu}");

              Console.WriteLine();
              voltarMenu();
         }
  static void Opcao5()
         {
            double n, exp, res;
            
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("        - EXPONENCIAÇÃO -        ");
           Console.ResetColor();
           Console.WriteLine();

           Console.Write("Digite a base..: ");
            n = double.Parse(Console.ReadLine());

           Console.Write("Digite o expoente..: ");
            exp = double.Parse(Console.ReadLine());

            res = Math.Pow(n, exp);
           
           Console.WriteLine();
           Console.WriteLine($"O resultado de {n} elevado a {exp} é {Math.Round(res)}");
           Console.WriteLine();

           voltarMenu();
        }
  static void Opcao6()
         {
           double raiz, res;
            
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("        - RAÍZ QUADRADA -        ");
           Console.ResetColor();
           Console.WriteLine();

           Console.Write("Digite o RADICANDO..: ");
            raiz = double.Parse(Console.ReadLine());

            res = Math.Sqrt(raiz);
           
           Console.WriteLine();
           Console.WriteLine($"A RAÍZ QUADRADA de {raiz} é {Math.Round(res)}");
           Console.WriteLine();

           voltarMenu();
              
    }
  static void Opcao7()
     {
       double a, b, c, x1, x2, delta;
          
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       - BHASKARA -       ");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Digite o Valor de A: ");
             a = double.Parse(Console.ReadLine());

            Console.Write("Digite o Valor de B: ");
             b = double.Parse(Console.ReadLine());

            Console.Write("Digite o Valor de C: ");
             c = double.Parse(Console.ReadLine());

             delta = Math.Pow(b, 2) - 4 * a * c;
             x1 = (-b + Math.Sqrt(delta)) / 2 * a;
             x2 = (-b - Math.Sqrt(delta)) / 2 * a;

            Console.WriteLine();
            Console.Write("X1 é ");
            Console.WriteLine(Math.Round(x1, 2));

            Console.Write("X2 é ");
            Console.WriteLine(Math.Round(x2, 2));

              if (a == 0){

                Console.Write("Não é uma equação do segundo grau");

             }else if(delta < 0) {

                Console.Write($"Como delta = {delta}, a equação não possui raízes reais!");
            }     

               Console.WriteLine();
               voltarMenu();


     }
  static void Opcao8()
       {
    Console.Clear();
    Console.WriteLine(">Sobre mim: ");
    Console.WriteLine();
    Console.WriteLine("Me chamo Isaac, tenho 18 anos, e sou aluno do curso de Informática da ETEC Adolpho Berezin, em Mongaguá/SP. ");
    Console.WriteLine();
    Console.WriteLine(">Sobre o programa: ");
    Console.WriteLine();
    Console.WriteLine("Esse é o meu primeiro programa, feito para o fim do 1º módulo do curso de Informática. Ele é o resultado do conhecimento que obtive durante esse módulo. Espero que gostem!");
    Console.WriteLine();
    Console.WriteLine("Link para o site: https://isaacgeazy.github.io/Calculadora/");

    Console.WriteLine();
    voltarMenu();
      }
  static void Opcao0()
         {
           string opS = "";
           
        Console.Clear();
    
        Console.WriteLine("Deseja mesmo sair? [S] SIM | [N] NÃO ");
        Console.WriteLine();
        Console.Write("Opção..:");
        opS = Console.ReadLine().ToUpper();


         
        if(opS == "S"){

          Console.Clear();

          Console.WriteLine("Obrigado por utilizar o programa...  :)" );

        } else if (opS == "N"){
        
         Console.Clear();

         ExibirMenu();

         Opcoes();
 
        }else{
         
          Console.WriteLine();
          Console.WriteLine("Somente [S] SIM e [N] NÃO");
          Console.ReadKey();
          Console.Clear();
          
          Opcao0();
         
        }
            
     }
  static void Opcoes()
    {
          string op = "";

              Console.Write("Opção..: ");
              op = Console.ReadLine();

              switch (op)
              {
                case "1":
                Opcao1();
                  break;
              
                case "2":
                Opcao2();
                break;

                case "3":
                Opcao3();
                break;

                case "4":
                Opcao4();
                break;

                case "5":
                Opcao5();
                break;

                case "6":
                Opcao6();
                break;

                case "7":
                Opcao7();
                break;

                case "8":
                Opcao8();
                break;

                case "0":
                Opcao0();
                break;
                
                default:               
                Console.WriteLine();
                Console.WriteLine("  Opção inválida!");
                Console.ReadKey();
                Console.Clear();
                ExibirMenu();
                Opcoes();
                 break;               
               }
    }
  static void voltarMenu()
     {
          string opV = "";  
    Console.WriteLine();
    Console.WriteLine("Pressione alguma tecla...");
    Console.ReadKey();

    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("Deseja: ");
    Console.WriteLine();
    Console.WriteLine("[V] VOLTAR ao menu | [S] SAIR do programa ");
    Console.WriteLine();

    Console.Write("Opção..: ");
    opV = Console.ReadLine().ToUpper();
    
    if(opV == "V"){
    
    Console.Clear();

    ExibirMenu();
    Opcoes();

    }else if(opV == "S"){
         
     Console.WriteLine();
     Console.WriteLine("Obrigado por utilizar o programa! :)");

    }else{  
    Console.WriteLine();
    Console.WriteLine("Opção Inválida. ");
    Console.WriteLine();
    Console.WriteLine("Pressione alguma tecla para VOLTAR as opções");
    Console.ReadKey();

    Console.Clear();   
    voltarMenu();

     }
        }
      }
    }
    

