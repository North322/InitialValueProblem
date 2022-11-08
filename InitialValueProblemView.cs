using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InitialValueProblem
{
    public partial class InitialValueProblemView : Form
    {
        public InitialValueProblemViewModel ViewModel { get; }
        public InitialValueProblemView()
        {
            InitializeComponent();
            ViewModel = new InitialValueProblemViewModel();
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

                ViewModel.AddSolver(Name, Type, Behavior);
                //SolverTabPage SolverTabPage = new SolverTabPage();  TODO: 
                //SolversTabControl.TabPages.Add(SolverTabPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void DeleteSolverButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = DeleteSolverNameTextBox.Text;
                int SolverIndex = ViewModel.Farm.FindSolverByName(Name);
                ViewModel.DeleteSolver(Name);
                SolversTabControl.SelectedIndex = SolverIndex;
                SolversTabControl.TabPages.Remove(SolversTabControl.SelectedTab);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                List<List<Point>> Solutions = ViewModel.SolveTask(new InitialValueProblem(y0, t0, t, h));
                string name = AddSolverNameTextBox.Text;

                this.chart.Series[0].Points.Clear();
                Farm Farms = new Farm();

                int i = 0, index = ViewModel.FindSolverByName(name);

                foreach (Point point in Solutions[index])
                {
                    Console.WriteLine($"x{i}: {point.X}, y{i}: {point.Y}");

                    this.chart.Series[0].Points.AddXY(point.X, point.Y);
                    i++;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            


        }

        private void UpdateTabsContent(List<List<Point>> Solutions) 
        {
            int index = 0;

            foreach(List<Point> points in Solutions)
            {
                SolversTabControl.SelectedIndex = index;
                
                index++;
            }
        }

        private void y0Label_Click(object sender, EventArgs e)
        {

        }

        private void t0Label_Click(object sender, EventArgs e)
        {

        }

        private void AddSolverPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitialValueProblemView_Load(object sender, EventArgs e)
        {

        }
    }
}
