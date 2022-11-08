using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitialValueProblem
{
    static class Program
    {
        public static string ListToString(List<Point> List)
        {
            string result = "";
            int i = 0;
            foreach (Point point in List)
            {
                result += $"x{i}: {point.X}  y{i}: {point.Y}\n";
                i++;
            }
            return result;
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitialValueProblemView());
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }
    }
}
