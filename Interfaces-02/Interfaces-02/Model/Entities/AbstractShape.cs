using Interfaces_02.Model.Enums;

namespace Interfaces_02.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
