namespace Personal_Planner
{
    partial class AddTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbTitle = new TextBox();
            tbDescription = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cbTaskType = new ComboBox();
            btnConfirmAddTask = new Button();
            btnCancelAddNewTask = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(73, 89);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(272, 23);
            tbTitle.TabIndex = 0;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(73, 148);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(272, 23);
            tbDescription.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(73, 207);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(272, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // cbTaskType
            // 
            cbTaskType.FormattingEnabled = true;
            cbTaskType.Location = new Point(70, 266);
            cbTaskType.Name = "cbTaskType";
            cbTaskType.Size = new Size(275, 23);
            cbTaskType.TabIndex = 3;
            // 
            // btnConfirmAddTask
            // 
            btnConfirmAddTask.BackColor = Color.Lime;
            btnConfirmAddTask.FlatAppearance.BorderSize = 0;
            btnConfirmAddTask.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnConfirmAddTask.FlatAppearance.MouseOverBackColor = Color.Green;
            btnConfirmAddTask.FlatStyle = FlatStyle.Flat;
            btnConfirmAddTask.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmAddTask.ForeColor = SystemColors.ControlText;
            btnConfirmAddTask.Location = new Point(28, 318);
            btnConfirmAddTask.Name = "btnConfirmAddTask";
            btnConfirmAddTask.Size = new Size(92, 36);
            btnConfirmAddTask.TabIndex = 4;
            btnConfirmAddTask.Text = "Add Task";
            btnConfirmAddTask.UseVisualStyleBackColor = false;
            btnConfirmAddTask.Click += btnConfirmAddTask_Click;
            // 
            // btnCancelAddNewTask
            // 
            btnCancelAddNewTask.BackColor = Color.Crimson;
            btnCancelAddNewTask.FlatAppearance.BorderSize = 0;
            btnCancelAddNewTask.FlatAppearance.MouseDownBackColor = Color.Pink;
            btnCancelAddNewTask.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btnCancelAddNewTask.FlatStyle = FlatStyle.Flat;
            btnCancelAddNewTask.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelAddNewTask.ForeColor = SystemColors.ControlText;
            btnCancelAddNewTask.Location = new Point(297, 318);
            btnCancelAddNewTask.Name = "btnCancelAddNewTask";
            btnCancelAddNewTask.Size = new Size(92, 36);
            btnCancelAddNewTask.TabIndex = 5;
            btnCancelAddNewTask.Text = "Cancel";
            btnCancelAddNewTask.UseVisualStyleBackColor = false;
            btnCancelAddNewTask.Click += btnCancelAddNewTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(171, 56);
            label1.Name = "label1";
            label1.Size = new Size(66, 30);
            label1.TabIndex = 6;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(137, 115);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 7;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(149, 174);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 8;
            label3.Text = "Due Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(142, 233);
            label4.Name = "label4";
            label4.Size = new Size(123, 30);
            label4.TabIndex = 9;
            label4.Text = "Task Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(149, 9);
            label5.Name = "label5";
            label5.Size = new Size(113, 30);
            label5.TabIndex = 10;
            label5.Text = "New Task";
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(420, 387);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelAddNewTask);
            Controls.Add(btnConfirmAddTask);
            Controls.Add(cbTaskType);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbDescription);
            Controls.Add(tbTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(436, 426);
            MinimumSize = new Size(436, 426);
            Name = "AddTaskForm";
            Text = "Add New Task";
            Load += AddTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTitle;
        private TextBox tbDescription;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbTaskType;
        private Button btnConfirmAddTask;
        private Button btnCancelAddNewTask;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}