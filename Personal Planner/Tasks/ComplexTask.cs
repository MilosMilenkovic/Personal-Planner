using Personal_Planner.Interfaces;
using Personal_Planner.Observer;
using Personal_Planner.Task;
using Personal_Planner.Utility;
using System;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Personal_Planner.Tasks
{

    public class ComplexTask:ITaskComponent,IComplexTaskControl,ICardDisplay, ITaskStorageOperations
    {
        private TaskSaveManager taskSaveManager = TaskSaveManager.Instance;
        private List<IObserver> observers = new List<IObserver>();
        public List<SimpleTask> components { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public TaskType Type { get; set; }
        public bool isComplete;
        private SubstasksForm form = new SubstasksForm();


        public ComplexTask()
        {

        }
        public ComplexTask(string title, string description, DateTime dueDate, TaskType type)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            Type = type;
            components = new List<SimpleTask>();
            isComplete = false;
        }
        
    
        public void Add(SimpleTask component)
        {
            components.Add(component);
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
                observer.TaskUpdated(this,text);
            }
        }
        public void MarkComplete()
        {
            this.isComplete = true;
            NotifyObservers("completed");
        }
        public string Display()
        {
            string s = "";
            s += $"Task {Title} {Description} {DueDate.ToString("dd-MM-yyyy")} {Type}\n";
            foreach (var component in components)
            {
                s+=component.Display();
                s += "\n";
            }
            return "Subtasks: " + s;
        }

   
        public Control MakeTaskCard(bool allowComplete, bool allowDelete)
        {
            
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Height = 200;
            panel.Width = 300;
            panel.BackColor = System.Drawing.Color.LightSkyBlue;
            panel.AutoScroll = true;
            panel.Tag = this;
            panel.Click += (sender, e) => OpenSubtasksForm(panel);
            AddLabelToPanel("Task:", Title, panel, 10);
            AddLabelToPanel("Description:", Description, panel, 40);
            AddLabelToPanel("Due Date:", DueDate.ToString("dd-MM-yyyy"), panel, 70);
            AddLabelToPanel("Type:", Type.ToString(), panel, 100);
            if (allowComplete)
            {
             
                CheckBox completeCheckBox = new CheckBox();
                completeCheckBox.Text = "Complete Task";
                completeCheckBox.Location = new System.Drawing.Point(10, panel.Height - 30);
                panel.Controls.Add(completeCheckBox);

            
                completeCheckBox.CheckedChanged += (sender, e) =>
                {
            
                    if (completeCheckBox.Checked)
                    {
                        completeCheckBox.Checked = false;
                        MarkComplete(panel);
                        
                    }
                  
                };
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
                        DeleteComplexTask(panel);
                 
                    }

                };
            }

           

            return panel;
        }
        private void DeleteComplexTask(Panel panel)
        {
            ComplexTask task = panel.Tag as ComplexTask;
           
            if (task != null)
            {
                this.RemoveTask(FilePaths.filePathComplex_progress, FilePaths.filePathComplex_removed);
                Panel parentPanel = panel.Parent as Panel;
                if (parentPanel != null)
                {
                    parentPanel.Controls.Remove(panel);
                    parentPanel.Refresh();
                }
            }
        }
        

        private void OpenSubtasksForm(Panel panel)
        {
            ComplexTask complexTask = panel.Tag as ComplexTask;

            if (complexTask != null)
            {
                form.ClearFlp();
                foreach (var subtask in complexTask.components)
                {
                    Panel subtaskPanel = (Panel)subtask.MakeTaskCard(true, true);
                    form.AddSubtaskPanel(subtaskPanel);
                   
                    CheckBox deleteCheckBox = subtaskPanel.Controls.OfType<CheckBox>().FirstOrDefault(cb => cb.Text == "Delete Task");
                    if (deleteCheckBox != null)
                    {
                        deleteCheckBox.CheckedChanged += (sender, e) =>
                        {
                            if (deleteCheckBox.Checked)
                            {
                                deleteCheckBox.Checked = false;

                            
                                complexTask.Remove(subtask);

                                form.ClearFlp();
                                foreach (var updatedSubtask in complexTask.components)
                                {
                                    Panel updatedSubtaskPanel = (Panel)updatedSubtask.MakeTaskCard(true, true);
                                    form.AddSubtaskPanel(updatedSubtaskPanel);
                                }
                            }
                        };
                    }
                }
                form.SetPanelTag(complexTask);
                form.ShowDialog();
            }
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


        public void Remove(SimpleTask component)
        {
            components.Remove(component);
        }
        public bool IsComplete()
        {
            return isComplete;
        }
        public void MarkComplete(Panel panel)
        {
            var nr_of_subtasks = components.Count;
            var nr_of_completed = 0;
            foreach (var component in components)
            {
                if (component.IsComplete() == true)
                {
                    nr_of_completed++;
                }
            }
            if (nr_of_completed == nr_of_subtasks)
            {
                MarkComplete();
                this.RemoveTask(FilePaths.filePathComplex_progress, FilePaths.filePathComplex_completed);
                Panel parentPanel = panel.Parent as Panel;
                if (parentPanel != null)
                {
                    parentPanel.Controls.Remove(panel);
                    parentPanel.Refresh();
                }
            }
            else
            {
    
                this.RemoveTask(FilePaths.filePathComplex_progress, FilePaths.garbage);
                this.SaveTask(FilePaths.filePathComplex_progress);
                MessageBox.Show("You haven't completed every subtask, unable to finish task.");

            }
        }



        public void SaveTask(string filePathWriteTo)
        {
            ComplexTask complexTask = this as ComplexTask;
            List<ComplexTask> complexTasks = new List<ComplexTask>();
            if (File.Exists(filePathWriteTo))
            {
               
                complexTasks.AddRange(taskSaveManager.LoadTasks("", filePathWriteTo).Cast<ComplexTask>());
            }

            complexTasks.Add(complexTask);

            var serializer = new XmlSerializer(typeof(List<ComplexTask>));

            using (var fileStream = new FileStream(filePathWriteTo, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fileStream, complexTasks);
            }
            complexTask.Subscribe(taskSaveManager);
            complexTask.NotifyObservers("updated");
        }

        public void RemoveTask(string filePathRemoveFrom, string filePathWriteTo)
        {
            ComplexTask complexTask=this as ComplexTask;
            List<ComplexTask> complexTasks = new List<ComplexTask>();
            complexTasks.AddRange(taskSaveManager.LoadTasks("",filePathRemoveFrom).Cast<ComplexTask>());

            if (complexTask != null)
            {

                complexTasks.RemoveAll(t => t.DueDate == complexTask.DueDate && t.Title == complexTask.Title && t.Description == complexTask.Description && t.Type == complexTask.Type);

                var serializer = new XmlSerializer(typeof(List<ComplexTask>));

                using (var fileStream = new FileStream(filePathRemoveFrom, FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(fileStream, complexTasks);
                }


                complexTask.SaveTask(filePathWriteTo);

            }
        }

        public void RemoveExpiredTask()
        {
            if (this.DueDate < DateTime.Now)
            {
                RemoveTask(FilePaths.filePathComplex_progress, FilePaths.complex_expired);
            }
        }
    }
}
