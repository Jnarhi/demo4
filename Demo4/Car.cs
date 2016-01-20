﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Car
    {
        // max speed
        private readonly int maxSpeed = 200;
        // member field
        private int speed;
        // property
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value <= maxSpeed) speed = value;
                else
                {
                    Console.WriteLine("Too much speed! - Speed set to max instead!");
                    speed = maxSpeed;
                }
            }
        }
        
    }
}
