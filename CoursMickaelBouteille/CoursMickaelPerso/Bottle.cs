using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursMickaelPerso
{
    class Bottle
    {
        private bool isOpen;

        //readonly pour le modifier uniquement dans le constructeur
        private readonly double capacity;

        private double currentVolume;

        //Constructeur de la bouteille
        public Bottle(double _capacity)
        {
            this.capacity = _capacity;
            this.isOpen = false;
            this.currentVolume = 0;
        }
        //Booleen pour Ouvrir la bouteille
        public bool Open()
        {
            isOpen = true;
            return isOpen;
        }
        //Booleen pour Fermer la bouteille
        public bool Close()
        {
            isOpen = false;
            return isOpen;
        }
        //Double permettant de remplir totalement la bouteille
        public double Fill()
        {       //Pas la peine de préciser true ou false vu que c'est déjà un boolean
            if (isOpen)
            {
                this.currentVolume = this.capacity;
            }

            return this.currentVolume;
        }
        //Double permettant de remplir partiellement la bouteille
        public double Fill(double _quantity)
        {
            if ((isOpen) && (_quantity > 0) && ((this.currentVolume + _quantity) <= capacity))
            {
                currentVolume += _quantity;
            }
            return this.currentVolume;
        }

        //Double permettant de vider totalement la bouteille
        public double Empty()
        {
            if (isOpen)
            {
                this.currentVolume = 0;
            }
            return this.currentVolume;
        }
        //Double permettant de vider partiellement la bouteille
        public double Empty(double _quantity)
        {
            if ((isOpen) && (_quantity > 0))
            {
                if (_quantity < currentVolume)
                {
                    currentVolume -= _quantity;
                }
                else
                {
                    currentVolume = 0;
                }
            }
            return currentVolume;
        }
        //Getter pour la variable d'instance capacity
        public double GetCapacity()
        {
            return capacity;
        }
        //Getter pour la variable d'instance currentVolume
        public double GetCurrentVolume()
        {
            return currentVolume;
        }
    }
}

