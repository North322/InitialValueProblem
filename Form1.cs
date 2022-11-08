using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitialValueProblem
{
    

    public partial class Form1 : Form
    {
        public Menu menu;
        public Form1()
        {
            InitializeComponent();
            menu = new Menu();
            BehaviorComboBox.SelectedIndex = 0;
            TypeComboBox.SelectedIndex = 0;
        }

        private void addSolverButton_Click(object sender, EventArgs e)
        {
            AddSolverPanel.Visible = true;
            SolveTaskPanel.Visible = false;
            DeleteSolverPanel.Visible = false;
        }

        private void solveTask_Click(object sender, EventArgs e)
        {
            AddSolverPanel.Visible = false; 
            SolveTaskPanel.Visible = true;
            DeleteSolverPanel.Visible = false;
        }

        private void deleteSolverButton_Click(object sender, EventArgs e)
        {
            SolveTaskPanel.Visible = false;
            AddSolverPanel.Visible = false;
            DeleteSolverPanel.Visible = true;
        }

        private void AddSolverButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = AddSolverNameTextBox.Text;
                Type Type = (Type) Convert.ToByte(TypeComboBox.SelectedIndex);
                Behavior Behavior = (Behavior) Convert.ToByte(BehaviorComboBox.SelectedIndex);
                menu.AddSolver(Name, Type, Behavior);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            } 
        }

        private void DeleteSolverButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = DeleteSolverNameTextBox.Text;
                menu.DeleteSolver(Name);
            } catch (Exception error)
            {
                // Show popup
            }
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            try
            {
                double y0 = Convert.ToDouble(y0TextBox.Text), 
                    t0 = Convert.ToDouble(t0TextBox.Text), 
                    t = Convert.ToDouble(tTextBox.Text), 
                    h = Convert.ToDouble(hTextBox.Text);

                List<List<Point>> Solutions = menu.SolveTask(new InitialValueProblem(y0, t0, t, h));
            } catch (Exception error)
            {
                // Show popup
            }
        }

        private void UpdateTabsContents(List<List<Point>> Solutions) 
        {
            int index = 0;

            foreach(List<Point> points in Solutions)
            {
                SolversTabControl.SelectedIndex = index;
                
                index++;
            }
        }
    }
}
