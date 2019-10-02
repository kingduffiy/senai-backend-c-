using System;
using Exercicio_Vingadores_POO.Models;

namespace Exercicio_Vingadores_POO.Controllers {
    public class HeróisController {
        HomemDeFerroModel HF = new HomemDeFerroModel ();
        CapitãoAméricaModel CAP = new CapitãoAméricaModel ();

        public void MostrarInformações () {
            string x = "";

            System.Console.WriteLine ("Escolha sua equipe: \n1- Team CAP (Capitão América)\n2-Team Stark (Homem de Ferro)");
            x = Console.ReadLine ();

            if (x == "1") {
                var x1 = "";
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Defina seu escudo:");
                CAP.Escudo = Console.ReadLine();
                System.Console.WriteLine ($"Você escolheu o CAPITÃO AMÉRICA.\nItem único: Escudo {CAP.Escudo}\nAções:\n1-Pular | 2-Lançar Escudo | 3-Defender-se com o Escudo | 4-WOMBO COMBO (todos os comandos) | 5-Sair do jogo");
                
                
                
                x1 = Console.ReadLine ();

                while (x1 != "5") {
                    if (x1 == "1") {
                        System.Console.WriteLine ("*Pulo*");
                    } else if (x1 == "2") {
                        System.Console.WriteLine ($"*Lançando escudo {CAP.Escudo}*");
                    } else if (x1 == "3") {
                        System.Console.WriteLine ($"*Defesa com Escudo {CAP.Escudo}*");
                    } else if (x1 == "4") {
                        System.Console.WriteLine ($"*Pulou, lançou o Escudo {CAP.Escudo} e se defendeu com o Escudo*");
                    } else if (x1 == "5") {
                        System.Console.WriteLine ("Você saiu do jogo");
                    } else {
                        System.Console.WriteLine ("Opção inválida");
                    }
                    System.Console.WriteLine ($"Ações:\n1-Pular | 2-Lançar Escudo {CAP.Escudo} | 3-Defender-se com o Escudo | 4-WOMBO COMBO (todos os comandos) | 5-Sair do jogo");
                    x1 = Console.ReadLine ();

                }
                Console.ForegroundColor = ConsoleColor.White;
            } else if(x == "2"){
                var x2 = "";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Defina sua Armadura:");
                HF.Armadura = Console.ReadLine();
                System.Console.WriteLine($"Você escolheu o HOMEM DE FERRO.\nItem único: Armadura {HF.Armadura}\n1-Pular | 2-Voar | 3-Atirar | 4-WOMBO COMBO (Todos os comandos) | 5-Sair do jogo");
                
                
                
                x2 = Console.ReadLine();
                
                while (x2 != "5") {
                    if (x2 == "1") {
                        System.Console.WriteLine ("*Pulo*");
                    } else if (x2 == "2") {
                        System.Console.WriteLine ("*Voando*");
                    } else if (x2 == "3") {
                        System.Console.WriteLine ("*Atirando*");
                    } else if (x2 == "4") {
                        System.Console.WriteLine ("*Pulou, Voou e atirou para todos os lados*");
                    } else if (x2 == "5") {
                        System.Console.WriteLine ("Você saiu do jogo");
                    } else {
                        System.Console.WriteLine ("Opção inválida");
                    }
                    System.Console.WriteLine($"Ações:\n1-Pular | 2-Voar | 3-Atirar | 4-WOMBO COMBO (Todos os comandos) | 5-Sair do jogo");
                x2 = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    }
}