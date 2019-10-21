using System;
using System.Collections.Generic;
using System.Text;

namespace UtilisateurMessage
{
    class Forum
    {
        private const int NBR_MESSAGES = 15;
        private int compteur;
        private MessageUtilisateur[] messages;

        public Forum()
        {
            messages = new MessageUtilisateur[NBR_MESSAGES];
        }

        public bool AjouterUtilisateurMessages(Utilisateur _utilisateur, Message _message)
        {
            for (int i = 0; i < NBR_MESSAGES; i++)
            {
                if (messages[i] == null)
                {
                    messages[i] = new MessageUtilisateur(_utilisateur, _message);

                    i++;

                    return true;
                }
            }
            Console.WriteLine("Il n'y a plus de places dans le tableau !");
            return false;
        }

        public void GetListMessagesAuteur()
        {
            string str = "";

            for (int i = 0; i < messages.Length; i++)
            {
                if(messages[i] != null)
                {
                    str += messages[i].Message.ToString() + "\n";
                }    
            }
            Console.WriteLine(str);
        }
    }
}
