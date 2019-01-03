using System;
using Eventos.IO.Domain.Eventos;

namespace Eventos.IO.Console.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var evento = new Evento(
                "Nome do Evento",
                "Descrição curta",
                "Descrição longa",
                DateTime.Now,
                DateTime.Now,
                false,
                50,
                false,
                "Nome da Empresa"
            );
            
            System.Console.WriteLine(evento.ToString());
            System.Console.ReadKey();
        }
    }
}
