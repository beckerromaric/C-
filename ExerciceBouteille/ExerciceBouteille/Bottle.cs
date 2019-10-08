using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceBouteille
{
    class Bottle
    {
        private Boolean isOpen;
        private float capacity;
        private float currentVolume;

        public Bottle(float _volume)
        {
            this.capacity = _volume;
        }

        public bool Open()
        {
            return this.isOpen = true;
        }

        public bool Close()
        {
            return isOpen = false;
        }

        public float Empty()
        {
            return capacity = 0.0f;
        }

 /*       public float Empty(float _volumeRetire)
        {
            
        }

        public float fill()
        {

        }

        public float fill(float)
        {

        }

        public float getCapacity()
        {

        }*/
    }
}
