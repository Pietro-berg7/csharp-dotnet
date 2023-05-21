using Interfaces2.Model.Enums;

namespace Interfaces2.Model.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
