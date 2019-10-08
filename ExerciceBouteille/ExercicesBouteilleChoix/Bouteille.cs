using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceBouteilleChoix
{
    class Bottle
    {
        private Boolean isOpen;
        private double capacity;
        private double currentVolume;

        public Bottle(double _volume)
        {
            this.capacity = _volume;
            this.isOpen = false;
            this.currentVolume = 0.0f;

        }

        public bool Open()
        {
            if (isOpen == false)
            {
                return this.isOpen = true;
            }
            else
            {
                Console.WriteLine("Impossible");
                return false;
            }

        }

        public bool Close()
        {
            if (isOpen == true)
            {
                return this.isOpen = false;
            }
            else
            {
                Console.WriteLine("Impossible");
                return true;
            }

        }

        public double Empty()
        {
            if (isOpen == true)
            {
                return capacity = 0.0f;
            }
            else
            {
                Console.WriteLine("Impossible");
                return currentVolume;
            }
        }

        public double Empty(double _volumeEmpty)
        {
            if (isOpen == true)
            {
                this.currentVolume -= _volumeEmpty;
            }
            else
            {
                Console.WriteLine("Impossible");
            }
            return currentVolume;
        }

        public double Fill()
        {
            if (isOpen == true && (this.currentVolume == 0.0d))
            {
                this.currentVolume = capacity;
            }
            else
            {
                Console.WriteLine("Impossible");

            }
            return currentVolume;
        }

        public double Fill(double _volumeFill)
        {
            if (isOpen == true)
            {
                if ((this.currentVolume + _volumeFill) <= this.capacity)
                {
                    this.currentVolume += _volumeFill;
                    return this.currentVolume;
                }
                else
                {
                    Console.WriteLine("Impossible");
                    return capacity;
                }

            }
            else
            {
                return this.currentVolume;
            }

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
