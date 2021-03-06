﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.FarmDecorator
{
    /// <summary>
    /// The abstract Decorator class.  
    /// </summary>
    public abstract class Decorator : RestaurantDish
    {
        protected RestaurantDish _dish;

        public Decorator(RestaurantDish dish)
        {
            _dish = dish;
        }

        public override void Display()
        {
            _dish.Display();
        }
    }
}
