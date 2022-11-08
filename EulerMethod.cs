using System.Collections.Generic;
namespace InitialValueProblem
{
    public class EulerSolver: Solver
    {
        // Constructors
        public EulerSolver(string _Name, Behavior _Behaviour) : base(_Name ,_Behaviour) { }
        
        // Methods
        public override List<Point> Solve(InitialValueProblem Task)
        {
            double PreviousFunctionValue, StepSize = Task.H;
            int i = 0;
            List<Point> Solution = new List<Point>();

            Solution.Add(new Point(Task.T0, Task.Y0));
            i++;

            while (Solution[i - 1].X < Task.T)
            {
                if ((Solution[i - 1].X + StepSize) > Task.T)
                {
                    switch (Behavior)
                    {
                        case Behavior.FinishAtTheRightBorder:
                            StepSize = Task.T - Solution[i - 1].X;
                            PreviousFunctionValue = Task.CountFunctionValue(Solution[i - 1].X, Solution[i - 1].Y);

                            Solution.Add(new Point(Solution[i - 1].X + StepSize, Solution[i - 1].Y + StepSize * PreviousFunctionValue));
                            break;

                        case Behavior.FinishAfterRightBorder:
                            PreviousFunctionValue = Task.CountFunctionValue(Solution[i - 1].X, Solution[i - 1].Y);

                            Solution.Add(new Point(Solution[i - 1].X + StepSize, Solution[i - 1].Y + StepSize * PreviousFunctionValue));
                            break;

                        case Behavior.FinishBeforeRightBorder:
                            break;                    
                    }
                    break;
                }

                PreviousFunctionValue = Task.CountFunctionValue(Solution[i - 1].X, Solution[i - 1].Y);
                Solution.Add(new Point(Solution[i - 1].X + StepSize, Solution[i - 1].Y + StepSize * PreviousFunctionValue));
                i++;
            }
            return Solution;
        }
    }    
}

