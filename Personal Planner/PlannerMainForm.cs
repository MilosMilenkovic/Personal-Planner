using Personal_Planner.Interfaces;
using Personal_Planner.Task;
using Personal_Planner.Tasks;
using Personal_Planner.Utility;
using System;

namespace Personal_Planner
{
    public partial class PlannerForm : Form
    {
        private TaskSaveManager taskSaveManager = TaskSaveManager.Instance;
        private static Random random = new Random();
        public static void Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public PlannerForm()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void PlannerForm_Load(object sender, EventArgs e)
        {
            btnCurrentTasks.PerformClick();
        }

        private void btnCurrentTasks_Click(object sender, EventArgs e)
        {
           DisplayTasks(FilePaths.filePathSimple_progress, FilePaths.filePathComplex_progress,true,true,true);
 
        }

        private void btnCompletedTasks_Click(object sender, EventArgs e)
        {
            DisplayTasks(FilePaths.filePathSimple_completed, FilePaths.filePathComplex_completed, false, false, false);

        }

        private void btnRemovedTasks_Click(object sender, EventArgs e)
        {
            DisplayTasks(FilePaths.filePathSimple_removed, FilePaths.filePathComplex_removed, false, false, false);
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TaskChoiceForm taskChoiceForm = new TaskChoiceForm();
            taskChoiceForm.FormClosed += TaskChoiceForm_FormClosed;
            taskChoiceForm.ShowDialog();
        }

        private void TaskChoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            btnCurrentTasks_Click(sender, e);
        }

        private void btnExpiredTasks_Click(object sender, EventArgs e)
        {
            DisplayTasks(FilePaths.simple_expired, FilePaths.complex_expired,false,false,false);
        }
        private void DisplayTasks(string filePathSimpleTask,string filePathComplexTask,bool completable,bool deletable,bool addTaskVisible)
        {
            flpMain.Controls.Clear();
            btnAddTask.Visible = addTaskVisible;
            List<ICardDisplay> tasksFull = taskSaveManager.LoadTasks(filePathSimpleTask, filePathComplexTask);
            Shuffle(tasksFull);
            foreach (ICardDisplay task in tasksFull)
            {
                Control taskCard = task.MakeTaskCard(completable, deletable);
                taskCard.Visible = true;
                flpMain.Controls.Add(taskCard);
            }
        }
    
    }
}