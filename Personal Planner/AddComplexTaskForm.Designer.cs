namespace Personal_Planner
{
    partial class AddComplexTaskForm
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelAddNewTask = new Button();
            btnConfirmAddComplexTask = new Button();
            cbTaskType = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            tbDescription = new TextBox();
            tbTitle = new TextBox();
            btnAddSubtask = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(91, 9);
            label5.Name = "label5";
            label5.Size = new Size(113, 30);
            label5.TabIndex = 21;
            label5.Text = "New Task";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(84, 227);
            label4.Name = "label4";
            label4.Size = new Size(123, 30);
            label4.TabIndex = 20;
            label4.Text = "Task Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(91, 168);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 19;
            label3.Text = "Due Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(79, 109);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 18;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(113, 50);
            label1.Name = "label1";
            label1.Size = new Size(66, 30);
            label1.TabIndex = 17;
            label1.Text = "Title:";
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
            btnCancelAddNewTask.Location = new Point(195, 369);
            btnCancelAddNewTask.Name = "btnCancelAddNewTask";
            btnCancelAddNewTask.Size = new Size(92, 36);
            btnCancelAddNewTask.TabIndex = 16;
            btnCancelAddNewTask.Text = "Cancel";
            btnCancelAddNewTask.UseVisualStyleBackColor = false;
            btnCancelAddNewTask.Click += btnCancelAddNewTask_Click;
            // 
            // btnConfirmAddComplexTask
            // 
            btnConfirmAddComplexTask.BackColor = Color.Lime;
            btnConfirmAddComplexTask.FlatAppearance.BorderSize = 0;
            btnConfirmAddComplexTask.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnConfirmAddComplexTask.FlatAppearance.MouseOverBackColor = Color.Green;
            btnConfirmAddComplexTask.FlatStyle = FlatStyle.Flat;
            btnConfirmAddComplexTask.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmAddComplexTask.ForeColor = SystemColors.ControlText;
            btnConfirmAddComplexTask.Location = new Point(12, 369);
            btnConfirmAddComplexTask.Name = "btnConfirmAddComplexTask";
            btnConfirmAddComplexTask.Size = new Size(92, 36);
            btnConfirmAddComplexTask.TabIndex = 15;
            btnConfirmAddComplexTask.Text = "Add Task";
            btnConfirmAddComplexTask.UseVisualStyleBackColor = false;
            btnConfirmAddComplexTask.Click += btnConfirmAddComplexTask_Click;
            // 
            // cbTaskType
            // 
            cbTaskType.FormattingEnabled = true;
            cbTaskType.Location = new Point(12, 260);
            cbTaskType.Name = "cbTaskType";
            cbTaskType.Size = new Size(275, 23);
            cbTaskType.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(15, 201);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(272, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(15, 142);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(272, 23);
            tbDescription.TabIndex = 12;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(15, 83);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(272, 23);
            tbTitle.TabIndex = 11;
            // 
            // btnAddSubtask
            // 
            btnAddSubtask.BackColor = Color.Gray;
            btnAddSubtask.FlatAppearance.BorderSize = 0;
            btnAddSubtask.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 64);
            btnAddSubtask.FlatAppearance.MouseOverBackColor = Color.Purple;
            btnAddSubtask.FlatStyle = FlatStyle.Flat;
            btnAddSubtask.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddSubtask.ForeColor = Color.Black;
            btnAddSubtask.Location = new Point(12, 300);
            btnAddSubtask.Name = "btnAddSubtask";
            btnAddSubtask.Size = new Size(275, 31);
            btnAddSubtask.TabIndex = 22;
            btnAddSubtask.Text = "Add Subtask";
            btnAddSubtask.UseVisualStyleBackColor = false;
            btnAddSubtask.Click += btnAddSubtask_Click;
            // 
            // AddComplexTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(302, 416);
            Controls.Add(btnAddSubtask);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelAddNewTask);
            Controls.Add(btnConfirmAddComplexTask);
            Controls.Add(cbTaskType);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbDescription);
            Controls.Add(tbTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddComplexTaskForm";
            Text = "Add Complex Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelAddNewTask;
        private Button btnConfirmAddComplexTask;
        private ComboBox cbTaskType;
        private DateTimePicker dateTimePicker1;
        private TextBox tbDescription;
        private TextBox tbTitle;
        private Button btnAddSubtask;
    }
}