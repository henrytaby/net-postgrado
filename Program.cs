// See https://aka.ms/new-console-template for more information
using Postgrado.Entidades;
using Postgrado.util;
using System;
using static System.Console;

namespace Postgrado
{
    class Postgrado{
        static void Main(string[] args){
            MockUniversidad UCatec = new MockUniversidad();
            UCatec.Inicializar();
            UCatec.Universidad?.Printer();
        }

        
    }

    
}