﻿/*
 * Define a class that holds information about a mobile phone device:
 * model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk)
 * and display characteristics (size and number of colors).
 * Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
 */

namespace MobilePhone
{
    using System;

    /// <summary>
    /// Display - size and number of colors
    /// </summary>
    public class Display
    {
        private decimal sizeInches;
        private uint totalColors;

        // Paramerless constrcutor - assume size is 1 inch, and has 1 color
        public Display() : this(1, 1)
        {
        }

        public Display(decimal diagonal, uint colors)
        {
            this.SizeInches = diagonal;
            this.TotalColors = colors;
        }

        public decimal SizeInches
        {
            get
            { 
                return this.sizeInches;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Display size cannot be negative!");
                }

                this.sizeInches = value;
            }
        }

        public uint TotalColors
        {
            get { return this.totalColors; }
            set { this.totalColors = value; }
        }
    }
}
