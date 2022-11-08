using System.Collections.Generic;
using System;

namespace InitialValueProblem
{
    public enum Behavior : byte { FinishAtTheLeftBorder = 1, FinishAfterLeftBorder, FinishBeforeLeftBorder };
    public enum Type : byte { EulerSolver = 1, HoinSolver };
    public abstract class Solver
    {
        // Class fields 
        private Behavior behavior;
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
        public Solver(string _Name, Behavior _Behavior)
        {
            
            Behavior = _Behavior;
            Name = _Name;
        } 
        // Methods
        public abstract List<Point> Solve(InitialValueProblem Task);
    }
}
