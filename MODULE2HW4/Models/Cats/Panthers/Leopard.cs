using MODULE2HW4.Enums;

namespace MODULE2HW4.Models.Cats
{
    public class Leopard : Panther
    {
        public Leopard()
        {
            SexualDimorphism = false;
            CatsTypeOfStains = CatsTypeOfStains.Stains;
        }
    }
}