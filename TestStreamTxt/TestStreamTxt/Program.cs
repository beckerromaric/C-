using Grpc.Core;
using Microsoft.CodeAnalysis.Text;
using System;
using System.IO;
namespace TestStreamTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = System.IO.File.ReadAllText(@"C:\Users\Bjormi\Desktop\C-\TestStreamTxt\exemple.txt");

            //Console.WriteLine("Contenu du fichier texte : exemple.txt = {0}", text);

            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Bjormi\Desktop\C-\TestStreamTxt\exemple.txt");

            //foreach (string line in lines)
            //{
            //    // Use a tab to indent each line of the file.
            //    Console.WriteLine("\t" + line);
            //}
            //string saisie;

            //StreamWriter monStream = new StreamWriter(@"C:\Users\Bjormi\Desktop\C-\TestStreamTxt\exemple.txt");
            //Console.WriteLine("Veuillez saisir une phrase a importer dans le fichier texte:");
            //saisie = Console.ReadLine();
            //monStream.WriteLine("\nBonjour le monde");
            //monStream.WriteLine(saisie);

            //monStream.Close();

            FileInfo monFichier = new FileInfo(@"C:\Users\Bjormi\Desktop\C-\TestStreamTxt");
            monFichier.Create();
        }

    }
}
