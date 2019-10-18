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
                
        }
    }
}
