namespace InitialValueProblem
{
    partial class InitialValueProblemView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SolversTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NavigationLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddSolverNavButton = new System.Windows.Forms.Button();
            this.AddSolverPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AddSolverNameTextBox = new System.Windows.Forms.TextBox();
            this.BehaviorComboBox = new System.Windows.Forms.ComboBox();
            this.BehaviorLabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddSolverNameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.AddSolverButton = new System.Windows.Forms.Button();
            this.DeleteSolverNavButton = new System.Windows.Forms.Button();
            this.SolveNavButton = new System.Windows.Forms.Button();
            this.SolveTaskPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hTextBox = new System.Windows.Forms.TextBox();
            this.tTextBox = new System.Windows.Forms.TextBox();
            this.tLabel = new System.Windows.Forms.Label();
            this.t0TextBox = new System.Windows.Forms.TextBox();
            this.y0TextBox = new System.Windows.Forms.TextBox();
            this.hLabel = new System.Windows.Forms.Label();
            this.y0Label = new System.Windows.Forms.Label();
            this.t0Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SolveButton = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DeleteSolverPanel = new System.Windows.Forms.Panel();
            this.DeleteSolverButton = new System.Windows.Forms.Button();
            this.DeleteSolverNameLabel = new System.Windows.Forms.Label();
            this.DeleteSolverNameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.SolversTabControl.SuspendLayout();
            this.NavigationLayout.SuspendLayout();
            this.AddSolverPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SolveTaskPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.DeleteSolverPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolversTabControl
            // 
            this.SolversTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolversTabControl.Controls.Add(this.tabPage1);
            this.SolversTabControl.Controls.Add(this.tabPage2);
            this.SolversTabControl.Location = new System.Drawing.Point(5, 499);
            this.SolversTabControl.Margin = new System.Windows.Forms.Padding(5);
            this.SolversTabControl.Name = "SolversTabControl";
            this.SolversTabControl.SelectedIndex = 0;
            this.SolversTabControl.Size = new System.Drawing.Size(1117, 191);
            this.SolversTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1109, 165);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(485, 178);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NavigationLayout
            // 
            this.NavigationLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NavigationLayout.ColumnCount = 1;
            this.NavigationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavigationLayout.Controls.Add(this.AddSolverNavButton, 0, 0);
            this.NavigationLayout.Controls.Add(this.DeleteSolverNavButton, 0, 1);
            this.NavigationLayout.Controls.Add(this.SolveNavButton, 0, 2);
            this.NavigationLayout.Controls.Add(this.panel1, 0, 3);
            this.NavigationLayout.Location = new System.Drawing.Point(7, 5);
            this.NavigationLayout.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.NavigationLayout.MaximumSize = new System.Drawing.Size(600, 550);
            this.NavigationLayout.MinimumSize = new System.Drawing.Size(520, 500);
            this.NavigationLayout.Name = "NavigationLayout";
            this.NavigationLayout.RowCount = 4;
            this.NavigationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.13131F));
            this.NavigationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.13131F));
            this.NavigationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.13131F));
            this.NavigationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.60606F));
            this.NavigationLayout.Size = new System.Drawing.Size(550, 500);
            this.NavigationLayout.TabIndex = 1;
            // 
            // AddSolverNavButton
            // 
            this.AddSolverNavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSolverNavButton.AutoSize = true;
            this.AddSolverNavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.AddSolverNavButton.Location = new System.Drawing.Point(3, 3);
            this.AddSolverNavButton.Name = "AddSolverNavButton";
            this.AddSolverNavButton.Size = new System.Drawing.Size(544, 59);
            this.AddSolverNavButton.TabIndex = 0;
            this.AddSolverNavButton.Text = "Add solver";
            this.AddSolverNavButton.UseVisualStyleBackColor = true;
            this.AddSolverNavButton.Click += new System.EventHandler(this.addSolverButton_Click);
            // 
            // AddSolverPanel
            // 
            this.AddSolverPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSolverPanel.Controls.Add(this.tableLayoutPanel3);
            this.AddSolverPanel.Location = new System.Drawing.Point(14, 16);
            this.AddSolverPanel.Name = "AddSolverPanel";
            this.AddSolverPanel.Size = new System.Drawing.Size(510, 277);
            this.AddSolverPanel.TabIndex = 1;
            this.AddSolverPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddSolverPanel_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.95216F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.04784F));
            this.tableLayoutPanel3.Controls.Add(this.AddSolverNameTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BehaviorComboBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.BehaviorLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.TypeComboBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.AddSolverNameLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.typeLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 18);
            this.tableLayoutPanel3.MinimumSize = new System.Drawing.Size(400, 250);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(477, 250);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // AddSolverNameTextBox
            // 
            this.AddSolverNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSolverNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSolverNameTextBox.Location = new System.Drawing.Point(117, 3);
            this.AddSolverNameTextBox.Name = "AddSolverNameTextBox";
            this.AddSolverNameTextBox.Size = new System.Drawing.Size(357, 31);
            this.AddSolverNameTextBox.TabIndex = 0;
            // 
            // BehaviorComboBox
            // 
            this.BehaviorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BehaviorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BehaviorComboBox.FormattingEnabled = true;
            this.BehaviorComboBox.Items.AddRange(new object[] {
            "Finish at the left border",
            "Finish after left border",
            "Finish before left border"});
            this.BehaviorComboBox.Location = new System.Drawing.Point(117, 127);
            this.BehaviorComboBox.Name = "BehaviorComboBox";
            this.BehaviorComboBox.Size = new System.Drawing.Size(357, 33);
            this.BehaviorComboBox.TabIndex = 2;
            // 
            // BehaviorLabel
            // 
            this.BehaviorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BehaviorLabel.AutoSize = true;
            this.BehaviorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BehaviorLabel.Location = new System.Drawing.Point(3, 124);
            this.BehaviorLabel.Name = "BehaviorLabel";
            this.BehaviorLabel.Size = new System.Drawing.Size(108, 25);
            this.BehaviorLabel.TabIndex = 5;
            this.BehaviorLabel.Text = "Behavior";
            this.BehaviorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeComboBox.DisplayMember = "EulerSolver";
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Euler solver",
            "Hoin solver"});
            this.TypeComboBox.Location = new System.Drawing.Point(117, 65);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(357, 33);
            this.TypeComboBox.TabIndex = 1;
            // 
            // AddSolverNameLabel
            // 
            this.AddSolverNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSolverNameLabel.AutoSize = true;
            this.AddSolverNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSolverNameLabel.Location = new System.Drawing.Point(3, 0);
            this.AddSolverNameLabel.Name = "AddSolverNameLabel";
            this.AddSolverNameLabel.Size = new System.Drawing.Size(108, 25);
            this.AddSolverNameLabel.TabIndex = 3;
            this.AddSolverNameLabel.Text = "Name";
            this.AddSolverNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(3, 62);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(108, 25);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Type";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.AddSolverButton, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(117, 189);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(357, 58);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // AddSolverButton
            // 
            this.AddSolverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSolverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.AddSolverButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddSolverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddSolverButton.Location = new System.Drawing.Point(244, 3);
            this.AddSolverButton.Name = "AddSolverButton";
            this.AddSolverButton.Size = new System.Drawing.Size(110, 33);
            this.AddSolverButton.TabIndex = 6;
            this.AddSolverButton.Text = "Add";
            this.AddSolverButton.UseVisualStyleBackColor = true;
            this.AddSolverButton.Click += new System.EventHandler(this.AddSolverButton_Click);
            // 
            // DeleteSolverNavButton
            // 
            this.DeleteSolverNavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSolverNavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.DeleteSolverNavButton.Location = new System.Drawing.Point(3, 68);
            this.DeleteSolverNavButton.Name = "DeleteSolverNavButton";
            this.DeleteSolverNavButton.Size = new System.Drawing.Size(544, 59);
            this.DeleteSolverNavButton.TabIndex = 1;
            this.DeleteSolverNavButton.Text = "Delete solver";
            this.DeleteSolverNavButton.UseVisualStyleBackColor = true;
            this.DeleteSolverNavButton.Click += new System.EventHandler(this.deleteSolverButton_Click);
            // 
            // SolveNavButton
            // 
            this.SolveNavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolveNavButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.SolveNavButton.Location = new System.Drawing.Point(3, 133);
            this.SolveNavButton.Name = "SolveNavButton";
            this.SolveNavButton.Size = new System.Drawing.Size(544, 59);
            this.SolveNavButton.TabIndex = 2;
            this.SolveNavButton.Text = "Solve task";
            this.SolveNavButton.UseVisualStyleBackColor = true;
            this.SolveNavButton.Click += new System.EventHandler(this.solveTask_Click);
            // 
            // SolveTaskPanel
            // 
            this.SolveTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolveTaskPanel.Controls.Add(this.tableLayoutPanel1);
            this.SolveTaskPanel.Location = new System.Drawing.Point(14, 7);
            this.SolveTaskPanel.Name = "SolveTaskPanel";
            this.SolveTaskPanel.Size = new System.Drawing.Size(530, 277);
            this.SolveTaskPanel.TabIndex = 7;
            this.SolveTaskPanel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.hTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.t0TextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.y0TextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.hLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.y0Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.t0Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 28);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(300, 250);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 250);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // hTextBox
            // 
            this.hTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hTextBox.Location = new System.Drawing.Point(48, 153);
            this.hTextBox.Name = "hTextBox";
            this.hTextBox.Size = new System.Drawing.Size(405, 31);
            this.hTextBox.TabIndex = 14;
            // 
            // tTextBox
            // 
            this.tTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tTextBox.Location = new System.Drawing.Point(48, 103);
            this.tTextBox.Name = "tTextBox";
            this.tTextBox.Size = new System.Drawing.Size(405, 31);
            this.tTextBox.TabIndex = 18;
            // 
            // tLabel
            // 
            this.tLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLabel.AutoSize = true;
            this.tLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tLabel.Location = new System.Drawing.Point(3, 100);
            this.tLabel.MinimumSize = new System.Drawing.Size(40, 0);
            this.tLabel.Name = "tLabel";
            this.tLabel.Size = new System.Drawing.Size(40, 50);
            this.tLabel.TabIndex = 19;
            this.tLabel.Text = "t";
            this.tLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // t0TextBox
            // 
            this.t0TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t0TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t0TextBox.Location = new System.Drawing.Point(48, 53);
            this.t0TextBox.Name = "t0TextBox";
            this.t0TextBox.Size = new System.Drawing.Size(405, 31);
            this.t0TextBox.TabIndex = 16;
            // 
            // y0TextBox
            // 
            this.y0TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.y0TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y0TextBox.Location = new System.Drawing.Point(48, 3);
            this.y0TextBox.Name = "y0TextBox";
            this.y0TextBox.Size = new System.Drawing.Size(405, 31);
            this.y0TextBox.TabIndex = 7;
            // 
            // hLabel
            // 
            this.hLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hLabel.AutoSize = true;
            this.hLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hLabel.Location = new System.Drawing.Point(3, 150);
            this.hLabel.MinimumSize = new System.Drawing.Size(40, 0);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(40, 50);
            this.hLabel.TabIndex = 15;
            this.hLabel.Text = "h";
            this.hLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // y0Label
            // 
            this.y0Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.y0Label.AutoSize = true;
            this.y0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y0Label.Location = new System.Drawing.Point(3, 0);
            this.y0Label.MinimumSize = new System.Drawing.Size(40, 0);
            this.y0Label.Name = "y0Label";
            this.y0Label.Size = new System.Drawing.Size(40, 25);
            this.y0Label.TabIndex = 10;
            this.y0Label.Text = "y0";
            this.y0Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.y0Label.Click += new System.EventHandler(this.y0Label_Click);
            // 
            // t0Label
            // 
            this.t0Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t0Label.AutoSize = true;
            this.t0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t0Label.Location = new System.Drawing.Point(3, 50);
            this.t0Label.MinimumSize = new System.Drawing.Size(40, 0);
            this.t0Label.Name = "t0Label";
            this.t0Label.Size = new System.Drawing.Size(40, 50);
            this.t0Label.TabIndex = 17;
            this.t0Label.Text = "t0";
            this.t0Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.t0Label.Click += new System.EventHandler(this.t0Label_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.SolveButton, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(48, 203);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(405, 42);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // SolveButton
            // 
            this.SolveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SolveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.SolveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SolveButton.Location = new System.Drawing.Point(279, 3);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(123, 33);
            this.SolveButton.TabIndex = 13;
            this.SolveButton.Text = "Solve";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea10.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea10);
            this.chart.Location = new System.Drawing.Point(563, 3);
            this.chart.Name = "chart";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.Red;
            series10.Name = "Series1";
            this.chart.Series.Add(series10);
            this.chart.Size = new System.Drawing.Size(555, 482);
            this.chart.TabIndex = 3;
            this.chart.Text = "chart";
            // 
            // DeleteSolverPanel
            // 
            this.DeleteSolverPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSolverPanel.Controls.Add(this.tableLayoutPanel5);
            this.DeleteSolverPanel.Location = new System.Drawing.Point(16, 26);
            this.DeleteSolverPanel.Name = "DeleteSolverPanel";
            this.DeleteSolverPanel.Size = new System.Drawing.Size(511, 228);
            this.DeleteSolverPanel.TabIndex = 20;
            // 
            // DeleteSolverButton
            // 
            this.DeleteSolverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSolverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.DeleteSolverButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteSolverButton.Location = new System.Drawing.Point(263, 3);
            this.DeleteSolverButton.Name = "DeleteSolverButton";
            this.DeleteSolverButton.Size = new System.Drawing.Size(107, 33);
            this.DeleteSolverButton.TabIndex = 13;
            this.DeleteSolverButton.Text = "Delete";
            this.DeleteSolverButton.UseVisualStyleBackColor = true;
            this.DeleteSolverButton.Click += new System.EventHandler(this.DeleteSolverButton_Click);
            // 
            // DeleteSolverNameLabel
            // 
            this.DeleteSolverNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSolverNameLabel.AutoSize = true;
            this.DeleteSolverNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSolverNameLabel.Location = new System.Drawing.Point(3, 0);
            this.DeleteSolverNameLabel.Name = "DeleteSolverNameLabel";
            this.DeleteSolverNameLabel.Size = new System.Drawing.Size(88, 48);
            this.DeleteSolverNameLabel.TabIndex = 10;
            this.DeleteSolverNameLabel.Text = "Name";
            this.DeleteSolverNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DeleteSolverNameTextBox
            // 
            this.DeleteSolverNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSolverNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSolverNameTextBox.Location = new System.Drawing.Point(97, 3);
            this.DeleteSolverNameTextBox.Name = "DeleteSolverNameTextBox";
            this.DeleteSolverNameTextBox.Size = new System.Drawing.Size(373, 31);
            this.DeleteSolverNameTextBox.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.Controls.Add(this.DeleteSolverNameTextBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.DeleteSolverNameLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(16, 64);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.02564F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.97436F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(473, 117);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.DeleteSolverButton, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(97, 51);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(373, 63);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.SolveTaskPanel);
            this.panel1.Controls.Add(this.AddSolverPanel);
            this.panel1.Controls.Add(this.DeleteSolverPanel);
            this.panel1.Location = new System.Drawing.Point(3, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 299);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.SolversTabControl, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel7.MinimumSize = new System.Drawing.Size(1127, 695);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.07914F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.92086F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1127, 695);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.chart, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.NavigationLayout, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1121, 488);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // InitialValueProblemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 699);
            this.Controls.Add(this.tableLayoutPanel7);
            this.MinimumSize = new System.Drawing.Size(1148, 738);
            this.Name = "InitialValueProblemView";
            this.Text = "Initial value problem";
            this.Load += new System.EventHandler(this.InitialValueProblemView_Load);
            this.SolversTabControl.ResumeLayout(false);
            this.NavigationLayout.ResumeLayout(false);
            this.NavigationLayout.PerformLayout();
            this.AddSolverPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.SolveTaskPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.DeleteSolverPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SolversTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel NavigationLayout;
        private System.Windows.Forms.Button AddSolverNavButton;
        private System.Windows.Forms.Button DeleteSolverNavButton;
        private System.Windows.Forms.Button SolveNavButton;
        private System.Windows.Forms.Panel AddSolverPanel;
        private System.Windows.Forms.TextBox AddSolverNameTextBox;
        private System.Windows.Forms.Label BehaviorLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label AddSolverNameLabel;
        private System.Windows.Forms.ComboBox BehaviorComboBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button AddSolverButton;
        private System.Windows.Forms.Panel SolveTaskPanel;
        private System.Windows.Forms.Label tLabel;
        private System.Windows.Forms.TextBox tTextBox;
        private System.Windows.Forms.Label t0Label;
        private System.Windows.Forms.TextBox t0TextBox;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.TextBox hTextBox;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Label y0Label;
        private System.Windows.Forms.TextBox y0TextBox;
        private System.Windows.Forms.Panel DeleteSolverPanel;
        private System.Windows.Forms.Button DeleteSolverButton;
        private System.Windows.Forms.Label DeleteSolverNameLabel;
        private System.Windows.Forms.TextBox DeleteSolverNameTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
    }
}

