using System;
using System.Collections.Generic;
namespace InitialValueProblem
{
    public class Menu
    { 
        // Properties
        public Farm Farm { get; }
        public List<List<Point>> Solutions { get; set; }
        
        // Constructors
        public Menu()
        {
            Farm = new Farm();
            Solutions = new List<List<Point>>();
        }
        
        // Methods
        public void AddSolver(string Name, Type Type, Behavior Behavior)
        {
            try
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
                        throw new ApplicationException("Wron behavior type!");
                }
            } catch(Exception error)
            {
                // Show popup
            }
        }

        public void DeleteSolver(string Name)
        {
            try { 
                Farm.DeleteSolver(Name);
            }
            catch (Exception error)
            {
                // Shop popup
            }
        }

        public List<List<Point>> SolveTask(InitialValueProblem initialValueProblem)
        {
            try
            {
                return Farm.SolveTask(initialValueProblem);
            }
            catch (Exception error)
            {
                return null; // ToDo: Show popup
            }
        }
    }
}
