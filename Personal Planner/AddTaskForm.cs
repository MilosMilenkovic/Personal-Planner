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
    public partial class AddTaskForm : Form
    {
        private bool isSubtask;
        private List<SimpleTask> subtasks;
        public AddTaskForm(bool isSubtask)
        {
            InitializeComponent();
            CenterToParent();
            this.isSubtask = isSubtask;
            subtasks = new List<SimpleTask>();
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            cbTaskType.DataSource = Enum.GetValues(typeof(TaskType));
            cbTaskType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelAddNewTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmAddTask_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string description = tbDescription.Text;
            DateTime dueDate = dateTimePicker1.Value;
            TaskType taskType = (TaskType)cbTaskType.SelectedValue;

            MessageBox.Show($"Title: {title}\nDescription: {description}\nDue Date: {dueDate}\nTask Type: {taskType}");

            SimpleTask task = new SimpleTask(title, description, dueDate, taskType);

            if (!isSubtask)
            {
                task.SaveTask(FilePaths.filePathSimple_progress);
            }
            else
            {
                subtasks.Add(task);
            }
            tbDescription.Clear();
            tbTitle.Clear();

        }
        public List<SimpleTask> Subtasks
        {
            get { return subtasks; }
        }
    }
}
