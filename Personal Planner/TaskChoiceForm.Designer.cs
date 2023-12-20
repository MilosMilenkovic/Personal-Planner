namespace Personal_Planner
{
    partial class TaskChoiceForm
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
            btnSimple = new Button();
            btnComplex = new Button();
            SuspendLayout();
            // 
            // btnSimple
            // 
            btnSimple.BackColor = Color.FromArgb(10, 10, 10);
            btnSimple.FlatAppearance.BorderSize = 0;
            btnSimple.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 58);
            btnSimple.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 72, 108);
            btnSimple.FlatStyle = FlatStyle.Flat;
            btnSimple.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimple.ForeColor = SystemColors.ButtonFace;
            btnSimple.Location = new Point(12, 12);
            btnSimple.Name = "btnSimple";
            btnSimple.Size = new Size(126, 56);
            btnSimple.TabIndex = 0;
            btnSimple.Text = "Simple Task";
            btnSimple.UseVisualStyleBackColor = false;
            btnSimple.Click += btnSimple_Click;
            // 
            // btnComplex
            // 
            btnComplex.BackColor = Color.FromArgb(10, 10, 10);
            btnComplex.FlatAppearance.BorderSize = 0;
            btnComplex.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 58);
            btnComplex.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 72, 108);
            btnComplex.FlatStyle = FlatStyle.Flat;
            btnComplex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnComplex.ForeColor = SystemColors.ButtonFace;
            btnComplex.Location = new Point(155, 12);
            btnComplex.Name = "btnComplex";
            btnComplex.Size = new Size(126, 56);
            btnComplex.TabIndex = 1;
            btnComplex.Text = "Complex Task";
            btnComplex.UseVisualStyleBackColor = false;
            btnComplex.Click += btnComplex_Click;
            // 
            // TaskChoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(290, 79);
            Controls.Add(btnComplex);
            Controls.Add(btnSimple);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TaskChoiceForm";
            Text = "Choose Task Type";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSimple;
        private Button btnComplex;
    }
}