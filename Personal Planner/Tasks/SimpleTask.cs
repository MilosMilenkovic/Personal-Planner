using Personal_Planner.Interfaces;
using Personal_Planner.Observer;
using Personal_Planner.Tasks;
using Personal_Planner.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Personal_Planner.Task
{

    public class SimpleTask : ITaskComponent, ICardDisplay, IObservableTask, ITaskStorageOperations
    {
        private TaskSaveManager taskSaveManager = TaskSaveManager.Instance;
        private List<IObserver> observers = new List<IObserver>();

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public TaskType Type { get; set; }

        public bool isComplete;

        public SimpleTask()
        {

        }
        public SimpleTask(string title, string description, DateTime dueDate, TaskType type)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            Type = type;
            isComplete = false;


        }

        public bool IsComplete()
        {
            return isComplete;
        }

        public void Subscribe(IObserver observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(String text)
        {
            foreach (var observer in observers)
            {
                observer.TaskUpdated(this, text);
            }
        }

        public void MarkComplete()
        {
            this.isComplete = true;

        }

        public string Display()
        {
            return $"{Title} {Description} {DueDate} {Type}";

        }




        public Control MakeTaskCard(bool allowComplete, bool allowDelete)
        {
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Height = 200;
            panel.Width = 300;
            panel.BackColor = System.Drawing.Color.LightBlue;
            panel.AutoScroll = true;
            panel.Tag = this;
            AddLabelToPanel("Task:", Title, panel, 10);
            AddLabelToPanel("Description:", Description, panel, 40);
            AddLabelToPanel("Due Date:", DueDate.ToString("dd-MM-yyyy"), panel, 70);
            AddLabelToPanel("Type:", Type.ToString(), panel, 100);


            if (allowComplete)
            {
                if (IsComplete() == false)
                {
                    CheckBox completeCheckBox = new CheckBox();
                    completeCheckBox.Text = "Complete Task";
                    completeCheckBox.Location = new System.Drawing.Point(10, panel.Height - 30);
                    panel.Controls.Add(completeCheckBox);

                    completeCheckBox.CheckedChanged += (sender, e) =>
                    {

                        if (completeCheckBox.Checked)
                        {

                            MarkComplete(panel);

                        }
                    };
                }
            }

            if (allowDelete)
            {
                CheckBox deleteCheckBox = new CheckBox();
                deleteCheckBox.Text = "Delete Task";
                deleteCheckBox.Location = new System.Drawing.Point(panel.Width - 110, panel.Height - 30);
                panel.Controls.Add(deleteCheckBox);

                deleteCheckBox.CheckedChanged += (sender, e) =>
                {

                    if (deleteCheckBox.Checked)
                    {
                        DeleteTask(panel);
                    }
                };
            }

            return panel;
        }

        private void AddLabelToPanel(string labelText, string content, Panel panel, int top)
        {
            Label label = new Label();
            label.Text = $"{labelText} {content}";
            label.Location = new System.Drawing.Point(10, top);
            label.Size = new System.Drawing.Size(280, 20);
            label.AutoSize = true;
            label.AutoEllipsis = true;

            panel.Controls.Add(label);

            top += label.Height + 5;
        }

        private void MarkComplete(Panel panel)
        {
            MarkComplete();
            SimpleTask task = panel.Tag as SimpleTask;

            if (task != null)
            {
                this.RemoveTask(FilePaths.filePathSimple_progress,FilePaths.filePathSimple_completed);
                Panel parentPanel = panel.Parent as Panel;
                if (parentPanel != null)
                {
                    parentPanel.Controls.Remove(panel);
                    parentPanel.Refresh();
                }
            }
        }

        private void DeleteTask(Panel panel)
        {
            SimpleTask task = panel.Tag as SimpleTask;

            if (task != null)
            {
                this.RemoveTask(FilePaths.filePathSimple_progress,FilePaths.filePathSimple_removed);
                Panel parentPanel = panel.Parent as Panel;
                if (parentPanel != null)
                {
                    parentPanel.Controls.Remove(panel);
                    parentPanel.Refresh();
                }
            }
        }

        public void SaveTask(string filePathWriteTo)
        {
            List<SimpleTask> simpleTasks=new List<SimpleTask>();
            SimpleTask simpleTask = this as SimpleTask;
            if (File.Exists(filePathWriteTo))
            {
                simpleTasks.AddRange(taskSaveManager.LoadTasks(filePathWriteTo, "").Cast<SimpleTask>());
            }


            simpleTasks.Add(simpleTask);


            var serializer = new XmlSerializer(typeof(List<SimpleTask>));

            using (var fileStream = new FileStream(filePathWriteTo, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fileStream, simpleTasks);

            }
            simpleTask.Subscribe(taskSaveManager);
            simpleTask.NotifyObservers("updated");
        }



        public void RemoveTask(string filePathRemoveFrom, string filePathWriteTo)
        {
            List<SimpleTask> simpleTasks=new List<SimpleTask>();
            simpleTasks.AddRange(taskSaveManager.LoadTasks(filePathRemoveFrom, "").Cast<SimpleTask>());
            SimpleTask simpleTask = this as SimpleTask;

            if (simpleTask != null)
            {
                simpleTasks.RemoveAll(t => t.DueDate == simpleTask.DueDate && t.Title==simpleTask.Title&&t.Description==simpleTask.Description&&t.Type==simpleTask.Type);
                var serializer = new XmlSerializer(typeof(List<SimpleTask>));

                using (var fileStream = new FileStream(filePathRemoveFrom, FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(fileStream, simpleTasks);


                }
                simpleTask.SaveTask(filePathWriteTo);

            }
        }

        public void RemoveExpiredTask()
        {
            if (this.DueDate < DateTime.Now)
            {
                RemoveTask(FilePaths.filePathSimple_progress, FilePaths.simple_expired);
            }
        }
    }
}

