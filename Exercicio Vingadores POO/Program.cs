using System;
using Exercicio_Vingadores_POO.Controllers;

namespace Exercicio_Vingadores_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            HeróisController jogo = new HeróisController();

            jogo.MostrarInformações();
        }
    }
}
