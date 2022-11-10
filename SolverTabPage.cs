using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitialValueProblem
{
    internal class SolverTabPage : TabPage
    {
        public Label SolverNameLabel { get; }
        public Label SolverTypeLabel { get; }
        public Label SolverBehaviorLabel { get; }
        public TextBox SolverSolutionTextBox { get; }

        public SolverTabPage(string _solverName, string _solverType, string _solverBehavior, string _solverSolution, int _tabIndex)
        {
            Font font = new Font("Microsoft Sans Serif", 15.0f);

            this.Text = _solverName;
            Label SolverNameDescriptionLabel = new Label
            {
                Font = font,
                AutoSize = true,
                Location = new System.Drawing.Point(17,30),
                Name = $"solverNameDescriptionLabel{_tabIndex}",
                TabIndex = _tabIndex,
                Text = "Solver Name:"
            };
            this.Controls.Add(SolverNameDescriptionLabel);

            Label SolverTypeDescriptionLabel = new Label
            {
                Font = font,
                AutoSize = true,
                Location = new System.Drawing.Point(17,60),
                Name = $"solverTypeDesctiptionLabel{_tabIndex}",
                TabIndex = _tabIndex,
                Text = "Solver Type:"
            };
            this.Controls.Add(SolverTypeDescriptionLabel);

            Label SolverBehaviorDescriptionLabel = new Label
            {
                Font = font,
                AutoSize = true,
                Location = new System.Drawing.Point(17,90),
                Name = $"solverBehaviorDesctiptionLabel{_tabIndex}",
                TabIndex = _tabIndex,
                Text = "Solver Behavior:"
            };
            this.Controls.Add(SolverBehaviorDescriptionLabel);

            Label SolverSolutionDescriptionLabel = new Label
            {
                Font = font,
                AutoSize = true,
                Location = new System.Drawing.Point(443,30),
                Name = $"solverSolutionDescriptionLabel{_tabIndex}",
                TabIndex = _tabIndex,
                Text = "Solver Solution:"
            };
            this.Controls.Add(SolverSolutionDescriptionLabel);

            SolverNameLabel = new Label
            {
                Font = font,
                AutoSize = true,
                Location = new System.Drawing.Point(180, 30),
                Name = $"solverNameLabel{_tabIndex}",
                TabIndex = _tabIndex,
                Text = _solverName
            };
            this.Controls.Add(SolverNameLabel);

            SolverTypeLabel = new Label
            {
                Font = font,
                AutoSize = true,
                Location = new System.Drawing.Point(180, 60),
                Name = $"solverTypeLabel{_tabIndex}",
                TabIndex = _tabIndex,
                Text = _solverType
            };
            this.Controls.Add(SolverTypeLabel);

            SolverBehaviorLabel = new Label
            {
                Font = font,
                AutoSize = true,
                Location = new System.Drawing.Point(180, 90),
                Name = $"solverBehaviorLabel{_tabIndex}",
                TabIndex = _tabIndex,
                Text = _solverBehavior
            };
            this.Controls.Add(SolverBehaviorLabel);

            SolverSolutionTextBox = new TextBox
            {
                Font = font,
                TabStop = false,
                AutoSize = true,
                Location = new System.Drawing.Point(600, 30),
                Multiline = true,
                ScrollBars = ScrollBars.Both,
                Width = 480,
                Height = 100,
                Name = $"solverSolutionLabel{_tabIndex}",
                TabIndex = _tabIndex,
                Text = _solverSolution,
                ReadOnly = true
            };
            this.Controls.Add(SolverSolutionTextBox);
        }
    }
}
