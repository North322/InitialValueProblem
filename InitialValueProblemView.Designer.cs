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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SolversTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NavigationLayout = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AddSolverNavButton = new System.Windows.Forms.Button();
            this.DeleteSolverNavButton = new System.Windows.Forms.Button();
            this.SolveNavButton = new System.Windows.Forms.Button();
            this.ContentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteSolverPanel = new System.Windows.Forms.Panel();
            this.AddSolverPanel = new System.Windows.Forms.Panel();
            this.AddSolverButton = new System.Windows.Forms.Button();
            this.BehaviorLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.AddSolverNameLabel = new System.Windows.Forms.Label();
            this.BehaviorComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddSolverNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteSolverButton = new System.Windows.Forms.Button();
            this.SolveTaskPanel = new System.Windows.Forms.Panel();
            this.tLabel = new System.Windows.Forms.Label();
            this.tTextBox = new System.Windows.Forms.TextBox();
            this.t0Label = new System.Windows.Forms.Label();
            this.t0TextBox = new System.Windows.Forms.TextBox();
            this.hLabel = new System.Windows.Forms.Label();
            this.hTextBox = new System.Windows.Forms.TextBox();
            this.SolveButton = new System.Windows.Forms.Button();
            this.y0Label = new System.Windows.Forms.Label();
            this.y0TextBox = new System.Windows.Forms.TextBox();
            this.DeleteSolverNameLabel = new System.Windows.Forms.Label();
            this.DeleteSolverNameTextBox = new System.Windows.Forms.TextBox();
            this.SolversTabControl.SuspendLayout();
            this.NavigationLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.ContentLayout.SuspendLayout();
            this.DeleteSolverPanel.SuspendLayout();
            this.AddSolverPanel.SuspendLayout();
            this.SolveTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolversTabControl
            // 
            this.SolversTabControl.Controls.Add(this.tabPage1);
            this.SolversTabControl.Controls.Add(this.tabPage2);
            this.SolversTabControl.Location = new System.Drawing.Point(5, 262);
            this.SolversTabControl.Margin = new System.Windows.Forms.Padding(5);
            this.SolversTabControl.Name = "SolversTabControl";
            this.SolversTabControl.SelectedIndex = 0;
            this.SolversTabControl.Size = new System.Drawing.Size(434, 162);
            this.SolversTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 136);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 136);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NavigationLayout
            // 
            this.NavigationLayout.ColumnCount = 1;
            this.NavigationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavigationLayout.Controls.Add(this.chart1, 0, 3);
            this.NavigationLayout.Controls.Add(this.AddSolverNavButton, 0, 0);
            this.NavigationLayout.Controls.Add(this.DeleteSolverNavButton, 0, 1);
            this.NavigationLayout.Controls.Add(this.SolveNavButton, 0, 2);
            this.NavigationLayout.Location = new System.Drawing.Point(10, 12);
            this.NavigationLayout.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.NavigationLayout.Name = "NavigationLayout";
            this.NavigationLayout.RowCount = 4;
            this.NavigationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.NavigationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.NavigationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.NavigationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.NavigationLayout.Size = new System.Drawing.Size(331, 424);
            this.NavigationLayout.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(3, 129);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(325, 292);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // AddSolverNavButton
            // 
            this.AddSolverNavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSolverNavButton.AutoSize = true;
            this.AddSolverNavButton.Location = new System.Drawing.Point(3, 3);
            this.AddSolverNavButton.Name = "AddSolverNavButton";
            this.AddSolverNavButton.Size = new System.Drawing.Size(325, 36);
            this.AddSolverNavButton.TabIndex = 0;
            this.AddSolverNavButton.Text = "Add solver";
            this.AddSolverNavButton.UseVisualStyleBackColor = true;
            this.AddSolverNavButton.Click += new System.EventHandler(this.addSolverButton_Click);
            // 
            // DeleteSolverNavButton
            // 
            this.DeleteSolverNavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSolverNavButton.Location = new System.Drawing.Point(3, 45);
            this.DeleteSolverNavButton.Name = "DeleteSolverNavButton";
            this.DeleteSolverNavButton.Size = new System.Drawing.Size(325, 36);
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
            this.SolveNavButton.Location = new System.Drawing.Point(3, 87);
            this.SolveNavButton.Name = "SolveNavButton";
            this.SolveNavButton.Size = new System.Drawing.Size(325, 36);
            this.SolveNavButton.TabIndex = 2;
            this.SolveNavButton.Text = "Solve task";
            this.SolveNavButton.UseVisualStyleBackColor = true;
            this.SolveNavButton.Click += new System.EventHandler(this.solveTask_Click);
            // 
            // ContentLayout
            // 
            this.ContentLayout.ColumnCount = 1;
            this.ContentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContentLayout.Controls.Add(this.DeleteSolverPanel, 0, 0);
            this.ContentLayout.Controls.Add(this.SolversTabControl, 0, 1);
            this.ContentLayout.Location = new System.Drawing.Point(344, 12);
            this.ContentLayout.Name = "ContentLayout";
            this.ContentLayout.RowCount = 2;
            this.ContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ContentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ContentLayout.Size = new System.Drawing.Size(444, 429);
            this.ContentLayout.TabIndex = 2;
            // 
            // DeleteSolverPanel
            // 
            this.DeleteSolverPanel.Controls.Add(this.AddSolverPanel);
            this.DeleteSolverPanel.Controls.Add(this.DeleteSolverButton);
            this.DeleteSolverPanel.Controls.Add(this.DeleteSolverNameLabel);
            this.DeleteSolverPanel.Controls.Add(this.DeleteSolverNameTextBox);
            this.DeleteSolverPanel.Location = new System.Drawing.Point(3, 3);
            this.DeleteSolverPanel.Name = "DeleteSolverPanel";
            this.DeleteSolverPanel.Size = new System.Drawing.Size(438, 251);
            this.DeleteSolverPanel.TabIndex = 20;
            // 
            // AddSolverPanel
            // 
            this.AddSolverPanel.Controls.Add(this.SolveTaskPanel);
            this.AddSolverPanel.Controls.Add(this.AddSolverButton);
            this.AddSolverPanel.Controls.Add(this.BehaviorLabel);
            this.AddSolverPanel.Controls.Add(this.typeLabel);
            this.AddSolverPanel.Controls.Add(this.AddSolverNameLabel);
            this.AddSolverPanel.Controls.Add(this.BehaviorComboBox);
            this.AddSolverPanel.Controls.Add(this.TypeComboBox);
            this.AddSolverPanel.Controls.Add(this.AddSolverNameTextBox);
            this.AddSolverPanel.Location = new System.Drawing.Point(2, 3);
            this.AddSolverPanel.Name = "AddSolverPanel";
            this.AddSolverPanel.Size = new System.Drawing.Size(439, 251);
            this.AddSolverPanel.TabIndex = 1;
            // 
            // AddSolverButton
            // 
            this.AddSolverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSolverButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddSolverButton.Location = new System.Drawing.Point(284, 179);
            this.AddSolverButton.Name = "AddSolverButton";
            this.AddSolverButton.Size = new System.Drawing.Size(110, 33);
            this.AddSolverButton.TabIndex = 6;
            this.AddSolverButton.Text = "Add";
            this.AddSolverButton.UseVisualStyleBackColor = true;
            this.AddSolverButton.Click += new System.EventHandler(this.AddSolverButton_Click);
            // 
            // BehaviorLabel
            // 
            this.BehaviorLabel.AutoSize = true;
            this.BehaviorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BehaviorLabel.Location = new System.Drawing.Point(12, 130);
            this.BehaviorLabel.Name = "BehaviorLabel";
            this.BehaviorLabel.Size = new System.Drawing.Size(97, 25);
            this.BehaviorLabel.TabIndex = 5;
            this.BehaviorLabel.Text = "Behavior";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(41, 87);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(60, 25);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Type";
            // 
            // AddSolverNameLabel
            // 
            this.AddSolverNameLabel.AutoSize = true;
            this.AddSolverNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSolverNameLabel.Location = new System.Drawing.Point(33, 45);
            this.AddSolverNameLabel.Name = "AddSolverNameLabel";
            this.AddSolverNameLabel.Size = new System.Drawing.Size(68, 25);
            this.AddSolverNameLabel.TabIndex = 3;
            this.AddSolverNameLabel.Text = "Name";
            // 
            // BehaviorComboBox
            // 
            this.BehaviorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BehaviorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BehaviorComboBox.FormattingEnabled = true;
            this.BehaviorComboBox.Items.AddRange(new object[] {
            "Finish at the left border",
            "Finish after left border",
            "Finish before left border"});
            this.BehaviorComboBox.Location = new System.Drawing.Point(125, 130);
            this.BehaviorComboBox.Name = "BehaviorComboBox";
            this.BehaviorComboBox.Size = new System.Drawing.Size(269, 33);
            this.BehaviorComboBox.TabIndex = 2;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DisplayMember = "EulerSolver";
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Euler solver",
            "Hoin solver"});
            this.TypeComboBox.Location = new System.Drawing.Point(125, 84);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(269, 33);
            this.TypeComboBox.TabIndex = 1;
            // 
            // AddSolverNameTextBox
            // 
            this.AddSolverNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSolverNameTextBox.Location = new System.Drawing.Point(125, 45);
            this.AddSolverNameTextBox.Name = "AddSolverNameTextBox";
            this.AddSolverNameTextBox.Size = new System.Drawing.Size(269, 31);
            this.AddSolverNameTextBox.TabIndex = 0;
            // 
            // DeleteSolverButton
            // 
            this.DeleteSolverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSolverButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteSolverButton.Location = new System.Drawing.Point(254, 166);
            this.DeleteSolverButton.Name = "DeleteSolverButton";
            this.DeleteSolverButton.Size = new System.Drawing.Size(110, 33);
            this.DeleteSolverButton.TabIndex = 13;
            this.DeleteSolverButton.Text = "Delete";
            this.DeleteSolverButton.UseVisualStyleBackColor = true;
            this.DeleteSolverButton.Click += new System.EventHandler(this.DeleteSolverButton_Click);
            // 
            // SolveTaskPanel
            // 
            this.SolveTaskPanel.Controls.Add(this.tLabel);
            this.SolveTaskPanel.Controls.Add(this.tTextBox);
            this.SolveTaskPanel.Controls.Add(this.t0Label);
            this.SolveTaskPanel.Controls.Add(this.t0TextBox);
            this.SolveTaskPanel.Controls.Add(this.hLabel);
            this.SolveTaskPanel.Controls.Add(this.hTextBox);
            this.SolveTaskPanel.Controls.Add(this.SolveButton);
            this.SolveTaskPanel.Controls.Add(this.y0Label);
            this.SolveTaskPanel.Controls.Add(this.y0TextBox);
            this.SolveTaskPanel.Location = new System.Drawing.Point(3, 3);
            this.SolveTaskPanel.Name = "SolveTaskPanel";
            this.SolveTaskPanel.Size = new System.Drawing.Size(417, 251);
            this.SolveTaskPanel.TabIndex = 7;
            this.SolveTaskPanel.Visible = false;
            // 
            // tLabel
            // 
            this.tLabel.AutoSize = true;
            this.tLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tLabel.Location = new System.Drawing.Point(85, 107);
            this.tLabel.Name = "tLabel";
            this.tLabel.Size = new System.Drawing.Size(18, 25);
            this.tLabel.TabIndex = 19;
            this.tLabel.Text = "t";
            // 
            // tTextBox
            // 
            this.tTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tTextBox.Location = new System.Drawing.Point(138, 101);
            this.tTextBox.Name = "tTextBox";
            this.tTextBox.Size = new System.Drawing.Size(206, 31);
            this.tTextBox.TabIndex = 18;
            // 
            // t0Label
            // 
            this.t0Label.AutoSize = true;
            this.t0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t0Label.Location = new System.Drawing.Point(73, 68);
            this.t0Label.Name = "t0Label";
            this.t0Label.Size = new System.Drawing.Size(30, 25);
            this.t0Label.TabIndex = 17;
            this.t0Label.Text = "t0";
            // 
            // t0TextBox
            // 
            this.t0TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t0TextBox.Location = new System.Drawing.Point(138, 65);
            this.t0TextBox.Name = "t0TextBox";
            this.t0TextBox.Size = new System.Drawing.Size(206, 31);
            this.t0TextBox.TabIndex = 16;
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hLabel.Location = new System.Drawing.Point(79, 149);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(24, 25);
            this.hLabel.TabIndex = 15;
            this.hLabel.Text = "h";
            // 
            // hTextBox
            // 
            this.hTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hTextBox.Location = new System.Drawing.Point(138, 138);
            this.hTextBox.Name = "hTextBox";
            this.hTextBox.Size = new System.Drawing.Size(206, 31);
            this.hTextBox.TabIndex = 14;
            // 
            // SolveButton
            // 
            this.SolveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SolveButton.Location = new System.Drawing.Point(234, 175);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(110, 33);
            this.SolveButton.TabIndex = 13;
            this.SolveButton.Text = "Solve";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // y0Label
            // 
            this.y0Label.AutoSize = true;
            this.y0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y0Label.Location = new System.Drawing.Point(68, 29);
            this.y0Label.Name = "y0Label";
            this.y0Label.Size = new System.Drawing.Size(35, 25);
            this.y0Label.TabIndex = 10;
            this.y0Label.Text = "y0";
            // 
            // y0TextBox
            // 
            this.y0TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y0TextBox.Location = new System.Drawing.Point(138, 28);
            this.y0TextBox.Name = "y0TextBox";
            this.y0TextBox.Size = new System.Drawing.Size(206, 31);
            this.y0TextBox.TabIndex = 7;
            // 
            // DeleteSolverNameLabel
            // 
            this.DeleteSolverNameLabel.AutoSize = true;
            this.DeleteSolverNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSolverNameLabel.Location = new System.Drawing.Point(62, 99);
            this.DeleteSolverNameLabel.Name = "DeleteSolverNameLabel";
            this.DeleteSolverNameLabel.Size = new System.Drawing.Size(68, 25);
            this.DeleteSolverNameLabel.TabIndex = 10;
            this.DeleteSolverNameLabel.Text = "Name";
            // 
            // DeleteSolverNameTextBox
            // 
            this.DeleteSolverNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSolverNameTextBox.Location = new System.Drawing.Point(149, 96);
            this.DeleteSolverNameTextBox.Name = "DeleteSolverNameTextBox";
            this.DeleteSolverNameTextBox.Size = new System.Drawing.Size(215, 31);
            this.DeleteSolverNameTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContentLayout);
            this.Controls.Add(this.NavigationLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SolversTabControl.ResumeLayout(false);
            this.NavigationLayout.ResumeLayout(false);
            this.NavigationLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ContentLayout.ResumeLayout(false);
            this.DeleteSolverPanel.ResumeLayout(false);
            this.DeleteSolverPanel.PerformLayout();
            this.AddSolverPanel.ResumeLayout(false);
            this.AddSolverPanel.PerformLayout();
            this.SolveTaskPanel.ResumeLayout(false);
            this.SolveTaskPanel.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel ContentLayout;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

