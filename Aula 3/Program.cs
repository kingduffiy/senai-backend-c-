using System;

namespace Aula_3 {
    class Program {
        static void Main (string[] args) {
            // // laço contado - for - incremento (+)
            // for (int cont1 = 1; cont <= 100; cont++) {

            //     // Verificamos se o número é diferente de par
            //     if (cont % 2 != 0) {
            //         Console.WriteLine ("FOR 0-100 - " + cont);
            //     }

            // }
            // // laço contado - for - decremento (-)
            // for (int cont2 = 100; cont >= 0; cont--) {
            //     if (cont % 2 != 0) {
            //         Console.WriteLine ("FOR 100-0 - " + cont);

            //     }

            // }

            // // Laço Condicional - While

            // double acumuladora1 = 0;
            // double nota = 0;
            // int cont3 = 0;
            // string sair ="";

            // while(sair != "sim"){
                
            //     Console.Write("Digite a nota de um aluno: ");
            //     nota = double.Parse(Console.ReadLine());

                
            //         acumuladora1 += nota;
            //         cont3++;

            //         Console.Write("PEDE PRA SAIR !!! ");
            //         sair = Console.ReadLine().ToLower();
            //     }
            //     Console.WriteLine("Média das notas : "+ (acumuladora1 / cont3) );

                int num;
                int cont = 0;
                int acum = 0;
            do{
              Console.WriteLine("Digite um número: ");
              num = int.Parse(Console.ReadLine());  
                if(num % 3 == 0){
                    acum += num;

                }

                cont++;
            }while(cont <= 20);

            Console.WriteLine("Numeros multiplos de 3" + acum);

            
            

            

        }

        }
    }