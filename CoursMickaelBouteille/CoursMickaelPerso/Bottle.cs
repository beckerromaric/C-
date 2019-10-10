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

        public Bottle(double _capacity)
        {
            this.capacity = _capacity;
            this.isOpen = false;
            this.currentVolume = 0;
        }

        public bool Open()
        {
            isOpen = true;
            return isOpen;
        }

        public bool Close()
        {
            isOpen = false;
            return isOpen;
        }

        public double Fill()
        {       //Pas la peine de préciser true ou false vu que c'est déjà un boolean
            if (isOpen)
            {
                this.currentVolume = this.capacity;
            }

            return this.currentVolume;
        }

        public double Fill(double _quantity)
        {
            if ((isOpen) && (_quantity > 0) && ((this.currentVolume + _quantity) <= capacity))
            {
                currentVolume += _quantity;
            }
            return this.currentVolume;
        }


        public double Empty()
        {
            if (isOpen)
            {
                this.currentVolume = 0;
            }
            return this.currentVolume;
        }

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

