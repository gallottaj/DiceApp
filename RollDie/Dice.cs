﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RollDie
{
    class Dice
    {
        public static int die1_face_value;
        public static int die2_face_value;
        public static Random random = new Random();
        private static int numberOfSides;
        public static int count = 0;
        public static int die1_sides = numberOfSides;
        public static int die2_sides = numberOfSides;

        static void Main(string[] args)
        {
            {
                //sets initial number of sides of die between 4 and 20
                numberOfSides = random.Next(4, 20);

                Console.WriteLine("Each die has" + " " + numberOfSides + " " + "sides");

                // creates object of class Dice 
                Dice d = new Dice();

                // calls rollDice method
                d.rollDice(); 

                // prints results to console
                Console.WriteLine("It took" + " " + count + " " + "roll(s) to get snake eyes!");
            }
        }
        public void rollDice()
        {
            do
            {
                // sets face value of each side of die between 1 and the number of sides

                die1_face_value = random.Next(1, numberOfSides);
                die2_face_value = random.Next(1, numberOfSides);
                count += 1;

                Console.WriteLine("The face values on this roll are" + " " + die1_face_value + " " + "and" + " " + die2_face_value);

            }

            while (die1_face_value + die2_face_value != 2);

            // the results print when above statement is false (die1_face_value + die2_face_value == 2)
        }
    }
}