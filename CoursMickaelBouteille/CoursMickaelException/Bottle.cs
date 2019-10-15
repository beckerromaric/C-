using System;
using System.Collections.Generic;
using System.Text;

namespace CoursMickaelException
{
    class Bottle
    {
        private bool isOpen;

        //readonly pour le modifier uniquement dans le constructeur
        private readonly double capacity;

        private double currentVolume;

        public Bottle(double _capacity)
        {
            if(_capacity < 0)
            {
                throw new ArgumentOutOfRangeException("Impossible de créer une bouteille à capacité négative");
            }

            if (_capacity > 10)
            {
                throw new ArgumentOutOfRangeException("Ce n'est pas une citerne que tu crée !");
            }
            this.capacity = _capacity;
            this.isOpen = false;
            this.currentVolume = 0;
        }

        public bool Open()
        {       //Pas la peine de préciser true ou false vu que c'est déjà un boolean
            if (isOpen)
            {
                throw new Exception("\nLa bouteille est déjà ouverte.\n");
            }
            isOpen = true;
            return isOpen;
        }

        public bool Close()
        {
            if (!isOpen)
            {
                throw new Exception("\nLa bouteille est déjà fermée.\n");
            }
            isOpen = false;
            return isOpen;
        }

        public double Fill()
        {
            if (!isOpen)
            {
                //throw new Exception("\nLa bouteille est fermée, vous ne pouvez pas la remplir !\n");
                throw new InvalidOperationException("\nBouteille fermée, vous ne pouvez pas remplir la bouteille !\n");
            }

            if (this.currentVolume == this.capacity)
            {
                //throw new Exception("\nVous ne pouvez pas remplir la bouteille car elle est déjà pleine !\n");
                throw new InvalidOperationException("Vous ne pouvez pas remplir la bouteille car elle est déjà pleine !");
            }

            

            this.currentVolume = this.capacity;


            return this.currentVolume;
        }

        public double Fill(double _quantity)
        {
            if (!isOpen)
            {
                //throw new Exception("\nLa bouteille est fermée, vous ne pouvez pas la remplir !\n");
                throw new InvalidOperationException("\nLa bouteille est fermée, vous ne pouvez pas la remplir !\n");
            }

            if (currentVolume == capacity)
            {
                //throw new Exception("\nLa bouteille est déjà remplie !\n");
                throw new InvalidOperationException("\nLa bouteille est déjà remplie !\n");
            }

            if ((_quantity + this.currentVolume) > this.capacity)
            {
                //throw new Exception("\nVous essayez de remplir plus que possible !\n");
                throw new InvalidOperationException("\nVous essayez de remplir plus que possible! " +
                                                    "Vous ne pouvez pas rajouter plus que "+ (capacity - currentVolume) +"\n" );
            }

            currentVolume += _quantity;

            return this.currentVolume;
        }


        public double Empty()
        {
            if (!isOpen)
            {
                //throw new Exception("\nLa bouteille est fermée, vous ne pouvez pas la vider !\n");
                throw new InvalidOperationException("\nLa bouteille est fermée, vous ne pouvez pas la vider !\n");
            }
            if(currentVolume == 0)
            {
                //throw new Exception("\nLa bouteille est déjà vide!\n");
                throw new InvalidOperationException("\nLa bouteille est déjà vide!\n");
            }

            //Plus besoin de mettre dans un if() car grace a l'exception le code s'arrête si il y a exception
            this.currentVolume = 0;

            return this.currentVolume;

        }

        public double Empty(double _quantity)
        {
            if (!isOpen)
            {
                //throw new Exception("\nLa bouteille est fermée, vous ne pouvez pas la vider !\n");
                throw new InvalidOperationException("\nLa bouteille est fermée, vous ne pouvez pas la vider !\n");
            }

            if(currentVolume == 0)
            {
                throw new InvalidOperationException("\nLa bouteille est vide, vous ne pouvez pas la vider !\n");
            }

            if(_quantity < 0)
            {
                throw new InvalidOperationException("\nVous avez saisi une valeur négative !\n");
            }

            if ((this.currentVolume - _quantity) < this.capacity)
            {                       //Il faut rajouter string.Format pour utiliser les marqueurs {0} , variable
                throw new Exception(string.Format("\nVous essayez de vider plus que possible! Remise à {0}.\n", currentVolume));
            }
 
            if (_quantity < currentVolume)
            {
                currentVolume -= _quantity;
            }
            else
            {
            currentVolume = 0;
            }
   
            return currentVolume;
        }

        public double GetCapacity()
        {
            return capacity;
        }

        public double GetCurrentVolume()
        {
            return currentVolume;
        }
    }
}
