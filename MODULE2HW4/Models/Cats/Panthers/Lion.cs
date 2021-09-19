using MODULE2HW4.Enums;

namespace MODULE2HW4.Models.Cats
{
    public class Lion : Panther
    {
        public Lion()
        {
            SexualDimorphism = true;
            CatsTypeOfStains = CatsTypeOfStains.NoStainsNoStripes;
        }
    }
}