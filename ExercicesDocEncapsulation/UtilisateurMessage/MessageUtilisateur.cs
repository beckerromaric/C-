using System;
using System.Collections.Generic;
using System.Text;

namespace UtilisateurMessage
{
    class MessageUtilisateur
    {
        private Utilisateur utilisateur;
        private Message message;

        public MessageUtilisateur(Utilisateur _utilisateur, Message _message)
        {
            this.utilisateur = _utilisateur;
            this.message = _message;
        }

        internal Utilisateur Utilisateur
        {
            get
            {
                return utilisateur;
            }
        }

        internal Message Message
        {
            get
            {
                return message;
            }
        }
    }
}
