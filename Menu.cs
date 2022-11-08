using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InitialValueProblem
{
    public class InitialValueProblemViewModel
    { 
        // Properties
        public Farm Farm { get; }
        public List<List<Point>> Solutions { get; set; }
        
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
                default:
                    // Probably for change
                    throw new ApplicationException("Wrong behavior type!");
            }
        }

        public void DeleteSolver(string Name)
        {
            Farm.DeleteSolver(Name);
        }

        public List<List<Point>> SolveTask(InitialValueProblem initialValueProblem)
        {
            return Farm.SolveTask(initialValueProblem);
        }
    }
}
