using Personal_Planner.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Text.Json.Serialization;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Xml.Serialization;
using Personal_Planner.Interfaces;
using Personal_Planner.Tasks;
using Personal_Planner.Observer;

namespace Personal_Planner.Utility
{
    public class TaskSaveManager:ObserverClass
    {

        private static TaskSaveManager instance;
 

        private TaskSaveManager() { }

        public static TaskSaveManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaskSaveManager();
                }
                return instance;
            }
        }

        public List<ICardDisplay> LoadTasks(string simpleTaskFilePath, string complexTaskFilePath)
        {
            List<ICardDisplay> tasksFull = new List<ICardDisplay>();

            if (File.Exists(simpleTaskFilePath))
            {
                var serializerSimple = new XmlSerializer(typeof(List<SimpleTask>));

                using (var fileStreamSimple = new FileStream(simpleTaskFilePath, FileMode.Open, FileAccess.Read))
                {
                        var simpleTasks = (List<SimpleTask>)serializerSimple.Deserialize(fileStreamSimple);
                        tasksFull.AddRange(simpleTasks.Cast<ICardDisplay>());
                      
                }
            }

            if (File.Exists(complexTaskFilePath))
            {
                var serializerComplex = new XmlSerializer(typeof(List<ComplexTask>));
                using (var fileStreamComplex = new FileStream(complexTaskFilePath, FileMode.Open, FileAccess.Read))
                {
                        var complexTasks = (List<ComplexTask>)serializerComplex.Deserialize(fileStreamComplex);
                        tasksFull.AddRange(complexTasks.Cast<ICardDisplay>());
                }
            }
            if (simpleTaskFilePath == FilePaths.filePathSimple_progress && complexTaskFilePath == FilePaths.filePathComplex_progress)
            {
                foreach (ITaskStorageOperations task in tasksFull)
                {
                    task.RemoveExpiredTask();   
                }
            }
            return tasksFull;
        }


      
    }
}
