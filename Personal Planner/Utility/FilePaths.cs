using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Planner.Utility
{
    public class FilePaths
    {
        public static string filePathSimple_progress = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\simple_tasks_in_progress.xml");
        public static string filePathComplex_progress = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\complex_tasks_in_progress.xml");
        public static string simple_expired = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\simple_tasks_expired.xml");
        public static string complex_expired = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\complex_tasks_expired.xml");
        public static string filePathSimple_removed = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\simple_tasks_deleted.xml");
        public static string filePathComplex_removed = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\complex_tasks_deleted.xml");
        public static string filePathSimple_completed = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\simple_tasks_completed.xml");
        public static string filePathComplex_completed = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\complex_tasks_completed.xml");
        public static string garbage = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\garbage.xml");
    }
    
}
