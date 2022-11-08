using Microsoft.VisualStudio.TestTools.UnitTesting;
using InitialValueProblemSolvers;
using System;
using System.Collections.Generic;
using System.Text;

namespace InitialValueProblemSolvers.Tests
{
    [TestClass()]
    public class HoinSolverTests
    {
        [TestMethod()]
        public void HoinSolverTest()
        {
            var Name = "Test name";
            Behavior Behavior = (Behavior)(1);
            HoinSolver solver = new HoinSolver(Name, Behavior);

            Assert.IsNotNull(solver);
        }

        private Farm _anInstance = new Farm();

        public void GenerateTestName(string Name = "Test name", byte behavior = 1)
        {
            Behavior Behavior = (Behavior)(behavior);
            HoinSolver testSolver = new HoinSolver(Name, Behavior);

            _anInstance.Solvers.Add(testSolver);
        }

        [TestMethod()]
        [Timeout(200)]  // Milliseconds
        public void SolveKoshiTaskTest()
        {
            var name = "Testname";
            GenerateTestName(name);
            InitialValueProblem task = new InitialValueProblem(1.0, 0.0, 1.0, 1.0);
            _anInstance.SolveTask(task);
            int i = 0, index = _anInstance.FindSolverByName(name);
            double expected = 1.0263281589577473;

            foreach (Point point in _anInstance.Solvers[index].Solution)
            {
                if (point.X == 1) Assert.AreEqual(expected, point.Y, 0.00001, "Hoina Method Calculating Error");

                Console.WriteLine($"x{i}: {point.X}, y{i}: {point.Y}");
                i++;
            }
        }
    }
}