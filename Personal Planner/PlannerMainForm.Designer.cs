namespace Personal_Planner
{
    partial class PlannerForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnExpiredTasks = new Button();
            btnAddTask = new Button();
            btnCompletedTasks = new Button();
            btnRemovedTasks = new Button();
            btnCurrentTasks = new Button();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            flpMain = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(btnExpiredTasks);
            panel1.Controls.Add(btnAddTask);
            panel1.Controls.Add(btnCompletedTasks);
            panel1.Controls.Add(btnRemovedTasks);
            panel1.Controls.Add(btnCurrentTasks);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 681);
            panel1.TabIndex = 0;
            // 
            // btnExpiredTasks
            // 
            btnExpiredTasks.BackColor = Color.Transparent;
            btnExpiredTasks.FlatAppearance.BorderColor = Color.White;
            btnExpiredTasks.FlatAppearance.BorderSize = 0;
            btnExpiredTasks.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 58);
            btnExpiredTasks.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 72, 108);
            btnExpiredTasks.FlatStyle = FlatStyle.Flat;
            btnExpiredTasks.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExpiredTasks.ForeColor = Color.Gainsboro;
            btnExpiredTasks.Image = Properties.Resources.clock;
            btnExpiredTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnExpiredTasks.Location = new Point(0, 414);
            btnExpiredTasks.Margin = new Padding(12, 0, 0, 0);
            btnExpiredTasks.Name = "btnExpiredTasks";
            btnExpiredTasks.Size = new Size(264, 56);
            btnExpiredTasks.TabIndex = 6;
            btnExpiredTasks.Text = "     Expired Tasks";
            btnExpiredTasks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExpiredTasks.UseVisualStyleBackColor = false;
            btnExpiredTasks.Click += btnExpiredTasks_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.Transparent;
            btnAddTask.FlatAppearance.BorderColor = Color.White;
            btnAddTask.FlatAppearance.BorderSize = 0;
            btnAddTask.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 58);
            btnAddTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 72, 108);
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddTask.ForeColor = Color.Gainsboro;
            btnAddTask.Image = Properties.Resources.plus;
            btnAddTask.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddTask.Location = new Point(0, 246);
            btnAddTask.Margin = new Padding(12, 0, 0, 0);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(264, 56);
            btnAddTask.TabIndex = 5;
            btnAddTask.Text = "        Add Task";
            btnAddTask.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Visible = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnCompletedTasks
            // 
            btnCompletedTasks.BackColor = Color.Transparent;
            btnCompletedTasks.FlatAppearance.BorderColor = Color.White;
            btnCompletedTasks.FlatAppearance.BorderSize = 0;
            btnCompletedTasks.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 58);
            btnCompletedTasks.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 72, 108);
            btnCompletedTasks.FlatStyle = FlatStyle.Flat;
            btnCompletedTasks.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompletedTasks.ForeColor = Color.Gainsboro;
            btnCompletedTasks.Image = Properties.Resources.check;
            btnCompletedTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompletedTasks.Location = new Point(0, 358);
            btnCompletedTasks.Margin = new Padding(12, 0, 0, 0);
            btnCompletedTasks.Name = "btnCompletedTasks";
            btnCompletedTasks.Size = new Size(264, 56);
            btnCompletedTasks.TabIndex = 4;
            btnCompletedTasks.Text = "    Completed Tasks";
            btnCompletedTasks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompletedTasks.UseVisualStyleBackColor = false;
            btnCompletedTasks.Click += btnCompletedTasks_Click;
            // 
            // btnRemovedTasks
            // 
            btnRemovedTasks.BackColor = Color.Transparent;
            btnRemovedTasks.FlatAppearance.BorderColor = Color.White;
            btnRemovedTasks.FlatAppearance.BorderSize = 0;
            btnRemovedTasks.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 58);
            btnRemovedTasks.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 72, 108);
            btnRemovedTasks.FlatStyle = FlatStyle.Flat;
            btnRemovedTasks.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemovedTasks.ForeColor = Color.Gainsboro;
            btnRemovedTasks.Image = Properties.Resources.delete;
            btnRemovedTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemovedTasks.Location = new Point(0, 470);
            btnRemovedTasks.Margin = new Padding(12, 0, 0, 0);
            btnRemovedTasks.Name = "btnRemovedTasks";
            btnRemovedTasks.Size = new Size(264, 56);
            btnRemovedTasks.TabIndex = 3;
            btnRemovedTasks.Text = "     Removed Tasks";
            btnRemovedTasks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemovedTasks.UseVisualStyleBackColor = false;
            btnRemovedTasks.Click += btnRemovedTasks_Click;
            // 
            // btnCurrentTasks
            // 
            btnCurrentTasks.BackColor = Color.Transparent;
            btnCurrentTasks.FlatAppearance.BorderColor = Color.White;
            btnCurrentTasks.FlatAppearance.BorderSize = 0;
            btnCurrentTasks.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 58);
            btnCurrentTasks.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 72, 108);
            btnCurrentTasks.FlatStyle = FlatStyle.Flat;
            btnCurrentTasks.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCurrentTasks.ForeColor = Color.Gainsboro;
            btnCurrentTasks.Image = Properties.Resources.loading;
            btnCurrentTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnCurrentTasks.Location = new Point(0, 302);
            btnCurrentTasks.Margin = new Padding(12, 0, 0, 0);
            btnCurrentTasks.Name = "btnCurrentTasks";
            btnCurrentTasks.Size = new Size(264, 56);
            btnCurrentTasks.TabIndex = 2;
            btnCurrentTasks.Text = "      Current Tasks";
            btnCurrentTasks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCurrentTasks.UseVisualStyleBackColor = false;
            btnCurrentTasks.Click += btnCurrentTasks_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Planner;
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // flpMain
            // 
            flpMain.AutoScroll = true;
            flpMain.BackColor = Color.FromArgb(51, 51, 80);
            flpMain.Dock = DockStyle.Right;
            flpMain.Location = new Point(241, 0);
            flpMain.Name = "flpMain";
            flpMain.Size = new Size(948, 681);
            flpMain.TabIndex = 1;
            // 
            // PlannerForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 681);
            Controls.Add(flpMain);
            Controls.Add(panel1);
            MaximumSize = new Size(1205, 720);
            MinimumSize = new Size(1205, 720);
            Name = "PlannerForm";
            Text = "Planner";
            Load += PlannerForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private Button btnRemovedTasks;
        private Button btnCurrentTasks;
        private Button btnCompletedTasks;
        private FlowLayoutPanel flpMain;
        private Button btnAddTask;
        private Button btnExpiredTasks;
    }
}