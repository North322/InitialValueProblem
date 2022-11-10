using System;

namespace InitialValueProblem
{
    public class InitialValueProblem
    {
        // Class fields
        private double t;
        private double h;
        
        // Properties
        public double Y0 { get; }

        public double T0 { get; }

        public double A { get; }

        public double B { get; }

        public double C { get; }
        public double T
        {
            get { return t; }
            set
            {
                if (value < T0)
                    throw new ArgumentException("Right border must be greater than left one");
                t = value;
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Step can't have zero or negative value");
                h = value;
            }
        }

        // Constructors
        public InitialValueProblem(double _Y0, double _T0, double _T, 
            double _H, double _A, double _B, double _C)
        {
            Y0 = _Y0;
            T0 = _T0;
            T = _T;
            H = _H;
            A = _A;
            B = _B;
            C = _C;
        }

        // Methods
        public double CountFunctionValue(double Xi, double Yi)
        {
            return A*Math.Sin(Math.Exp((Xi + Yi) * B) * Math.PI * C / 180);
        }
    }
}
