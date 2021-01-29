using System;

namespace Geometry
{
    public enum PointColour
    {
        Red, 
        Green,
        Blue
    }
    public interface IReflectable
    {
        void ReflectX();
        void ReflectY();
    }
    public class Point : IReflectable
    {
        private decimal x;
        private decimal y;

        public decimal X { get => x; }
        public decimal Y { get => y; }


        public Point(decimal x)
        {
            this.x = x;
            y = 0;
        }
        public Point(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }
        public void ReflectX()
        {
            x = -x;
        }
        public void ReflectY()
        {
            y = -y;
        }
    }
    public class ColourfulPoint : Point
    {
        private PointColour colour;

        public PointColour Colour { get => colour; }

        public ColourfulPoint(decimal x, decimal y, PointColour colour) : base(x, y)
        { 
            this.colour = colour;
        }

        public ColourfulPoint(decimal x, PointColour colour) : base(x)
            {
            this.colour = colour;
        }
    }
    }
