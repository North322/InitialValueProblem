using Microsoft.VisualStudio.TestTools.UnitTesting;
using InitialValueProblemSolvers;
using System;
using System.Collections.Generic;
using System.Text;

namespace InitialValueProblemSolvers.Tests
{
    class SolverTestMethod : Solver
    {
        public SolverTestMethod(string _Name, Behavior _Behaviour) : base(_Name, _Behaviour) { }

        public override void SolveKoshiTask(InitialValueProblem Task)
        {
            return; // as if the code here has worked and returns
        }
    }

    [TestClass()]
    public class SolverTests
    {
        private SolverTestMethod SolverTest()
        {
            var Name = "Test name";
            Behavior Behavior = (Behavior)Convert.ToByte(1);
            SolverTestMethod solver = new SolverTestMethod(Name, Behavior);

            return solver;
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
            "SolverName shouldn't be empty, null, or white space!")]
        public void Name_ThrowExceptionTest()
        {
            var Name = "";
            Behavior Behavior = (Behavior)Convert.ToByte(1);
            SolverTestMethod solver = new SolverTestMethod(Name, Behavior);
        }

        [TestMethod()]
        public void SolveKoshiTaskTest()
        {
            var solver = SolverTest();

            InitialValueProblem Task = new InitialValueProblem(1.0, 1.0, 1.1, 1.0);

            solver.SolveKoshiTask(Task);
        }

        
    }
}