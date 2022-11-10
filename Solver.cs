using System.Collections.Generic;
using System;
using System.ComponentModel;

namespace InitialValueProblem
{
    public enum Behavior : byte { FinishAtTheRightBorder = 1, FinishAfterRightBorder, FinishBeforeRightBorder };
    public enum Type : byte { EulerSolver = 1, HoinSolver };
    public abstract class Solver
    {
        // Class fields 
        private string name;

        // Properties
        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("SolverName shouldn't be empty, null, or white space!");
                name = value;
            }
        }
        public Behavior Behavior { get; }
        // Constructors
        public Solver(string _Name, Behavior _behavior)
        {
            Name = _Name;
            Behavior = _behavior;
        } 
        // Methods
        public abstract List<Point> Solve(InitialValueProblem Task);
    }
}
