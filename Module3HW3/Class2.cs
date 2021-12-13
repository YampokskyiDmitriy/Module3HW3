using System;

namespace Module3HW3
{
    public class Class2
    {
        private double _pow;

        public Func<double, bool> Calc(Func<double, double, double> powHandler, double x, double y)
        {
            _pow = powHandler(x, y);
            Func<double, bool> resultHandler = Result;
            return resultHandler;
        }

        public bool Result(double x)
        {
            return _pow % x == 0;
        }
    }
}
