using MODULE2HW4.Models;

namespace MODULE2HW4.Services.Abstractions
{
    public interface ISectionService
    {
        Animal[] Section { get; }

        void Add(Animal animal);

        Animal[] Get();

        void Print();
    }
}