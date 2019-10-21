using System;

namespace UtilisateurMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Utilisateur jean = new Utilisateur("Jean", "Dupont", "STANDARD");
            Utilisateur bernard = new Utilisateur("Bernard", "Morin", "STANDARD");
            Utilisateur nathalie = new Utilisateur("Nathalie", "Morin", "MODERATEUR");

            Console.WriteLine(jean.ToString());
            Console.WriteLine(bernard.ToString());
            Console.WriteLine(nathalie.ToString());

            Message message1 = new Message("Java SE", "L'encapsulation est une propriété fondamentale\n", jean);

            Console.WriteLine(message1.ToString());

            Message message2 = new Message("JAVA SE", "L'héritage en est une autre\n", bernard);

            Message message3 = new Message("Java SE", "Le polymorphisme est implicite en Java\n", nathalie);

            Message message4 = new Message("Java SE", "Les annotations sont pratiques en Java\n", jean);

            Forum forumMessages = new Forum();

            forumMessages.AjouterUtilisateurMessages(jean, message1);
            forumMessages.AjouterUtilisateurMessages(bernard, message2);
            forumMessages.AjouterUtilisateurMessages(nathalie, message3);
            forumMessages.AjouterUtilisateurMessages(jean, message4);

            forumMessages.GetListMessagesAuteur();

            Console.ReadLine();
        }
    }
}
