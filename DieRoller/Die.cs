﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1-6)
    /// </summary>
    public class Die
    {
        /// <summary>
        /// Creates the die and rolls it to start with a random number. 
        /// </summary>
        public Die()
        {
            Roll();
        }
        /// <summary>
        /// The current face up value of the die.
        /// Face Value = Number on the die (1-6)
        /// </summary>
        public byte FaceValue { get; private set; }
        
        /// <summary>
        /// True if the die is currently held (held means to that it won't change)
        /// </summary>
        public bool IsHeld {  get; set; }

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue">
        /// to the new face value. Returns the new face value. 
        /// </summary>
        /// <returns> Returns the new random face value </returns>
        public byte Roll() 
        { 
            //Generate random number.
            Random random = new Random();
            byte newValue = (byte)random.Next(1, 7);

            //set to face value.
            FaceValue = newValue;

            //return new number
            return FaceValue;   

         
        }

    }
}
