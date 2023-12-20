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
    public partial class TaskChoiceForm : Form
    {
        public TaskChoiceForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(false);
            addTaskForm.ShowDialog();

        }

        private void btnComplex_Click(object sender, EventArgs e)
        {
            AddComplexTaskForm addComplexTaskForm = new AddComplexTaskForm();
            addComplexTaskForm.ShowDialog();
        }
    }
}
