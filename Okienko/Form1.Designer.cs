namespace Okienko
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_NumberOfItem = new Label();
            txtBox_NumberOfItems = new TextBox();
            lbl_Seed = new Label();
            txtBox_Seed = new TextBox();
            lbl_Capacity = new Label();
            txtBox_Capacity = new TextBox();
            btn_Run = new Button();
            lbl_Instances = new Label();
            txtBox_Instances = new TextBox();
            lbl_Results = new Label();
            txtBox_Results = new TextBox();
            SuspendLayout();
            // 
            // lbl_NumberOfItem
            // 
            lbl_NumberOfItem.AutoSize = true;
            lbl_NumberOfItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_NumberOfItem.Location = new Point(109, 157);
            lbl_NumberOfItem.Name = "lbl_NumberOfItem";
            lbl_NumberOfItem.Size = new Size(144, 23);
            lbl_NumberOfItem.TabIndex = 0;
            lbl_NumberOfItem.Text = "Number of items:";
            lbl_NumberOfItem.Click += lbl_NumberOfItem_Click;
            // 
            // txtBox_NumberOfItems
            // 
            txtBox_NumberOfItems.Location = new Point(109, 181);
            txtBox_NumberOfItems.Margin = new Padding(3, 4, 3, 4);
            txtBox_NumberOfItems.Name = "txtBox_NumberOfItems";
            txtBox_NumberOfItems.Size = new Size(114, 27);
            txtBox_NumberOfItems.TabIndex = 1;
            txtBox_NumberOfItems.TextChanged += txtBox_NumberOfItems_TextChanged;
            // 
            // lbl_Seed
            // 
            lbl_Seed.AutoSize = true;
            lbl_Seed.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_Seed.Location = new Point(109, 236);
            lbl_Seed.Name = "lbl_Seed";
            lbl_Seed.Size = new Size(51, 23);
            lbl_Seed.TabIndex = 2;
            lbl_Seed.Text = "Seed:";
            lbl_Seed.Click += lbl_Seed_Click;
            // 
            // txtBox_Seed
            // 
            txtBox_Seed.Location = new Point(109, 260);
            txtBox_Seed.Margin = new Padding(3, 4, 3, 4);
            txtBox_Seed.Name = "txtBox_Seed";
            txtBox_Seed.Size = new Size(114, 27);
            txtBox_Seed.TabIndex = 3;
            txtBox_Seed.TextChanged += txtBox_Seed_TextChanged;
            // 
            // lbl_Capacity
            // 
            lbl_Capacity.AutoSize = true;
            lbl_Capacity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_Capacity.Location = new Point(109, 323);
            lbl_Capacity.Name = "lbl_Capacity";
            lbl_Capacity.Size = new Size(80, 23);
            lbl_Capacity.TabIndex = 4;
            lbl_Capacity.Text = "Capacity:";
            lbl_Capacity.Click += lbl_Capacity_Click;
            // 
            // txtBox_Capacity
            // 
            txtBox_Capacity.Location = new Point(109, 347);
            txtBox_Capacity.Margin = new Padding(3, 4, 3, 4);
            txtBox_Capacity.Name = "txtBox_Capacity";
            txtBox_Capacity.Size = new Size(114, 27);
            txtBox_Capacity.TabIndex = 5;
            txtBox_Capacity.TextChanged += txtBox_Capacity_TextChanged;
            // 
            // btn_Run
            // 
            btn_Run.BackColor = SystemColors.ActiveCaption;
            btn_Run.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_Run.Location = new Point(109, 400);
            btn_Run.Margin = new Padding(3, 4, 3, 4);
            btn_Run.Name = "btn_Run";
            btn_Run.Size = new Size(130, 61);
            btn_Run.TabIndex = 6;
            btn_Run.Text = "Run";
            btn_Run.UseVisualStyleBackColor = false;
            btn_Run.Click += btn_Run_Click;
            // 
            // lbl_Instances
            // 
            lbl_Instances.AutoSize = true;
            lbl_Instances.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_Instances.Location = new Point(419, 40);
            lbl_Instances.Name = "lbl_Instances";
            lbl_Instances.Size = new Size(85, 23);
            lbl_Instances.TabIndex = 7;
            lbl_Instances.Text = "Instances:";
            // 
            // txtBox_Instances
            // 
            txtBox_Instances.Location = new Point(419, 67);
            txtBox_Instances.Margin = new Padding(3, 4, 3, 4);
            txtBox_Instances.Multiline = true;
            txtBox_Instances.Name = "txtBox_Instances";
            txtBox_Instances.ReadOnly = true;
            txtBox_Instances.ScrollBars = ScrollBars.Vertical;
            txtBox_Instances.Size = new Size(479, 271);
            txtBox_Instances.TabIndex = 8;
            txtBox_Instances.TextChanged += txtBox_Instances_TextChanged;
            // 
            // lbl_Results
            // 
            lbl_Results.AutoSize = true;
            lbl_Results.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_Results.Location = new Point(419, 356);
            lbl_Results.Name = "lbl_Results";
            lbl_Results.Size = new Size(68, 23);
            lbl_Results.TabIndex = 9;
            lbl_Results.Text = "Results:";
            // 
            // txtBox_Results
            // 
            txtBox_Results.AcceptsReturn = true;
            txtBox_Results.AcceptsTab = true;
            txtBox_Results.Location = new Point(419, 383);
            txtBox_Results.Margin = new Padding(3, 4, 3, 4);
            txtBox_Results.Multiline = true;
            txtBox_Results.Name = "txtBox_Results";
            txtBox_Results.ReadOnly = true;
            txtBox_Results.ScrollBars = ScrollBars.Vertical;
            txtBox_Results.Size = new Size(479, 271);
            txtBox_Results.TabIndex = 10;
            txtBox_Results.TextChanged += txtBox_Results_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 671);
            Controls.Add(txtBox_Results);
            Controls.Add(lbl_Results);
            Controls.Add(txtBox_Instances);
            Controls.Add(lbl_Instances);
            Controls.Add(btn_Run);
            Controls.Add(txtBox_Capacity);
            Controls.Add(lbl_Capacity);
            Controls.Add(txtBox_Seed);
            Controls.Add(lbl_Seed);
            Controls.Add(txtBox_NumberOfItems);
            Controls.Add(lbl_NumberOfItem);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "ProblemPlecakowy";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_NumberOfItem;
        private TextBox txtBox_NumberOfItems;
        private Label lbl_Seed;
        private TextBox txtBox_Seed;
        private Label lbl_Capacity;
        private TextBox txtBox_Capacity;
        private Button btn_Run;
        private Label lbl_Instances;
        private TextBox txtBox_Instances;
        private Label lbl_Results;
        private TextBox txtBox_Results;
    }
}
