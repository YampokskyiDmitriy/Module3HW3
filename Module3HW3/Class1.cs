using System;

namespace Module3HW3
{
    public class Class1
    {
        public Action<bool> ShowHandler { get; } = Program.Show;

        public double Pow(double x, double y)
        {
            return x * y;
        }
    }
}