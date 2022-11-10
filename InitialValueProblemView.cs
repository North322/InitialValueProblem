using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace InitialValueProblem
{
    public partial class InitialValueProblemView : Form
    {
        public InitialValueProblemViewModel ViewModel { get; }
        public List<Color> Palette { get; }

        static public string GetEnumDescription(Enum value)
        {
            FieldInfo FieldInfo = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = FieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
        public static string ListToString(List<Point> List)
        {
            string result = "";
            int i = 0;
            foreach (Point point in List)
            {
                result += $"x{i}: {point.X}  y{i}: {point.Y}\r\n";
                i++;
            }
            return result;
        }
        
        public InitialValueProblemView()
        {
            InitializeComponent();
            ViewModel = new InitialValueProblemViewModel();
            Palette = new List<Color>();
            Palette.Add(Color.FromArgb(0x003f5c));
            Palette.Add(Color.FromArgb(0x444e86));
            Palette.Add(Color.FromArgb(0x955196));
            Palette.Add(Color.FromArgb(0xdd5182));
            Palette.Add(Color.FromArgb(0xff6354));
            Palette.Add(Color.FromArgb(0xffa600));
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
                SolverTabPage SolverTabPage = new SolverTabPage(Name, GetEnumDescription(Type), 
                    GetEnumDescription(Behavior), "", SolversTabControl.TabPages.Count); 
                SolversTabControl.TabPages.Add(SolverTabPage);
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
                    h = Convert.ToDouble(hTextBox.Text),
                    a = Convert.ToDouble(aTextBox.Text),
                    b = Convert.ToDouble(cTextBox.Text),
                    c = Convert.ToDouble(bTextBox.Text);

                List<List<Point>> Solutions = ViewModel.SolveTask(new InitialValueProblem(y0, t0, t, h, a, b, c));
                
                this.chart.Series[0].Points.Clear();
                Farm Farms = new Farm();

                UpdateChart(Solutions);
                UpdateSolversSolutionTabs(Solutions);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void UpdateChart(List<List<Point>> Solutions)
        {
            /* TODO:
                (V) Доработать графики
                (V) Организовать смену цветов
                (V) Оптимизировать вывод большого кол-ва точек
                (?) Обновлять графики при удалении/добавлении Solver
            */

            int SolutionIndex = 0;
            chart.Series.Clear();
            foreach (List<Point> Solution in Solutions)
            {
                chart.Series.Add(SolutionIndex.ToString());
                chart.Series[SolutionIndex].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart.Series[SolutionIndex].BorderWidth = 3;

                chart.Series[SolutionIndex].BorderColor = Palette[SolutionIndex % Palette.Count];

                int WhichDotToDraw = (Solution.Count > 100) ? Solution.Count / 100 : 1;


                for (int i = 0; i < Solution.Count; i += WhichDotToDraw)
                {

                    this.chart.Series[SolutionIndex].Points.AddXY(Solution[i].X, Solution[i].Y);
                }
                SolutionIndex++;
            }
        }
        private void UpdateSolversSolutionTabs(List<List<Point>> Solutions)
        {
            for (int i = 0; i < SolversTabControl.TabCount; i++)
            {
                SolversTabControl.SelectTab(i);
                SolversTabControl.SelectedTab.Controls[$"SolverSolutionLabel{i}"].Text = ListToString(Solutions[i]);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
