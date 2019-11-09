using Microsoft.CodeAnalysis.Text;
using System;
using System.IO;
namespace TestStreamTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Bjormi\Desktop\exemple.txt");

            Console.WriteLine("Contenu du fichier texte : exemple.txt = {0}", text);


        }

    }
}
