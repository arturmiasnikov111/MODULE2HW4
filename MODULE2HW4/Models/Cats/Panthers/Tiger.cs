using MODULE2HW4.Enums;

namespace MODULE2HW4.Models.Cats
{
    public class Tiger : Panther
    {
        public Tiger()
        {
            SexualDimorphism = false;
            CatsTypeOfStains = CatsTypeOfStains.Stripes;
        }
    }
}