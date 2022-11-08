using Microsoft.VisualStudio.TestTools.UnitTesting;
using InitialValueProblemSolvers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml.Linq;

namespace InitialValueProblemSolvers.Tests
{
    [TestClass()]
    public class EulerSolverTests
    {
        [TestMethod()]
        public void EulerSolverTest()
        {
            var Name = "Test name";
            Behavior behavior = (Behavior)Convert.ToByte(1);
            EulerSolver solver = new EulerSolver(Name, behavior);

            Assert.IsNotNull(solver);
        }

        private Farm _anInstance = new Farm();

        public void GenerateTestName(string Name = "Test name", byte behavior = 1)
        {
            Behavior Behavior = (Behavior)(behavior);
            EulerSolver testSolver = new EulerSolver(Name, Behavior);

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
            double expected = 1.0174524064372834;

            foreach (Point point in _anInstance.Solvers[index].Solution)
            {
                if (point.X == 1) Assert.AreEqual(expected, point.Y, 0.00001, "Euler Method Calculating Error");

                Console.WriteLine($"x{i}: {point.X}, y{i}: {point.Y}");
                i++;
            }
        }
    }
}