using Personal_Planner.Interfaces;
using Personal_Planner.Task;
using Personal_Planner.Tasks;
using Personal_Planner.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Planner
{

    public partial class AddComplexTaskForm : Form
    {
        private List<SimpleTask> subtasks = new List<SimpleTask>();


        public AddComplexTaskForm()
        {
            InitializeComponent();
            CenterToParent();
            cbTaskType.DataSource = Enum.GetValues(typeof(TaskType));
            cbTaskType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConfirmAddComplexTask_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string description = tbDescription.Text;
            DateTime dueDate = dateTimePicker1.Value;
            TaskType taskType = (TaskType)cbTaskType.SelectedValue;

            ComplexTask task = new ComplexTask(title, description, dueDate, taskType);
            foreach (SimpleTask task_simple in subtasks)
            {
                task.Add(task_simple);
            }
            if (task.components.Count < 2)
            {
                MessageBox.Show("A complex task must have at least 2 subtasks.");

            }
            else
            {
                task.SaveTask(FilePaths.filePathComplex_progress);
            }
            tbDescription.Clear();
            tbTitle.Clear();


        }

        private void btnCancelAddNewTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSubtask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(true);
            addTaskForm.ShowDialog();
            subtasks = addTaskForm.Subtasks;


        }
    }
}
