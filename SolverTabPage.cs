using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace InitialValueProblem
{
    public class SolverTabPage : System.Windows.Forms.TabPage
    {
        private Label SolverTypeLabel;
        private Label SolverBehaviorLabel;
        private Label SolverSolutionLabel;

        public SolverTabPage(string _solverName, string _solverType, string _solverBehavior)
        {
            this.SolverTypeLabel = new Label();
            this.SettingsPage.Controls.Add(this.SolverTypeLabel);
        }
    }
}
