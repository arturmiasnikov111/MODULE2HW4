using MODULE2HW4.Enums;

namespace MODULE2HW4.Models.Cats
{
    public abstract class Cats : Animal
    {
        public Cats()
        {
            IsDangerousToOtherAnimals = true;
            HasTail = true;
        }

        public bool SexualDimorphism { get; init; }

        public CatsTypeOfStains CatsTypeOfStains { get; init; }

        public override bool IsDangerousToOtherAnimals { get; init; }
    }
}