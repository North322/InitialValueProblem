using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InitialValueProblem
{
    public class InitialValueProblemViewModel
    { 
        // Properties
        public Farm Farm { get; }
        public List<List<Point>> Solutions { get; }
        
        // Constructors
        public InitialValueProblemViewModel()
        {
            Farm = new Farm();
            Solutions = new List<List<Point>>();
        }
        
        // Methods
        public void AddSolver(string Name, Type Type, Behavior Behavior)
        {
            switch (Type)
            {
                case Type.EulerSolver:
                    Farm.AddSolver(new EulerSolver(Name, Behavior));
                    break;
                case Type.HoinSolver:
                    Farm.AddSolver(new HoinSolver(Name, Behavior));
                    break;
            }
        }

        public void DeleteSolver(string Name)
        {
            Farm.DeleteSolver(Name);
        }

        public int FindSolverByName(string Name)
        {
            return Farm.FindSolverByName(Name);    
        }

        public List<List<Point>> SolveTask(InitialValueProblem initialValueProblem)
        {
            return Farm.SolveTask(initialValueProblem);
        }
    }
}
