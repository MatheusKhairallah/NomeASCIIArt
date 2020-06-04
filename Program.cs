using System;
using Figgle;
using Humanizer;
namespace NomeASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digíte seu nome: ");
            string nome=Console.ReadLine();
            string arte=FiggleFonts.Slant.Render(nome);
            Console.WriteLine(arte);
            
        }
    }
}
