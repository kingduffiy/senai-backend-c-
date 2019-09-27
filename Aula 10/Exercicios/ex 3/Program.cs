using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            System.Console.WriteLine( MostraInfo() );
            System.Console.WriteLine( MostraInfo( "João" , " Victor"));
            System.Console.WriteLine( MostraInfo("Idade: 16", " Peso: 67Kg", " Altura: 1.78"));
        }
            static string MostraInfo(){
                return "Escola SENAI de informática";
            }

            static string MostraInfo(string nome, string sobrenome){
                return nome + sobrenome;
            }
            static string MostraInfo(string idade, string peso, string altura){
                return idade + peso + altura;

            }
        }
    }

