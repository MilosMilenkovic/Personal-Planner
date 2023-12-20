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
    public partial class SubstasksForm : Form
    {

        public SubstasksForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        public void AddSubtaskPanel(Panel subtaskPanel)
        {
            flowLayoutPanel1.Controls.Add(subtaskPanel);
        }
        public void SetPanelTag(ComplexTask task)
        {
            flowLayoutPanel1.Tag = task;
        }
        public void ClearFlp()
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
