using System;

namespace MODULE2HW4.Models
{
    public class Weight
    {
        private const int ZeroWeight = 0;
        public Weight(double animalWeight)
        {
            IsWeightAboveZero(animalWeight);
        }

        public double AnimalWeight { get; set; }

        private bool IsWeightAboveZero(double weight)
        {
            if (weight > ZeroWeight)
            {
                AnimalWeight = weight;
                return true;
            }

            Console.WriteLine($"{nameof(AnimalWeight)} in class {nameof(Weight)} can`t be below {ZeroWeight}." +
                              $"Now it was set as {weight}");
            Environment.Exit(0);
            return false;
        }
    }
}