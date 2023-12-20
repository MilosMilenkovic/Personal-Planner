using Personal_Planner.Interfaces;
using Personal_Planner.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Planner.Observer
{
    public class ObserverClass : IObserver
    {
        public void TaskUpdated(ITaskComponent task,string text)
        {
                MessageBox.Show($"\nOBSERVER:Task {task.Display()} " + text + "\n");
        }
    }
}
