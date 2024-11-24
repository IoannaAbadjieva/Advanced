﻿namespace Zoo
{
    public class Animal
    {
        public Animal(string spieces, string diet, double weight, double length)
        {
            Species = spieces;
            Diet = diet;
            Weight = weight;
            Length = length;
        }

        public string Species { get; private set; }

        public string Diet { get; private set; }

        public double Weight { get; private set; }

        public double Length { get; private set; }


        public override string ToString()
        {
            return $"The {Species} is a {Diet} and weighs {Weight} kg.";
        }

    }
}