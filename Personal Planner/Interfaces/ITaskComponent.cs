using Personal_Planner.Task;
using Personal_Planner.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Personal_Planner.Interfaces
{
   
    public interface ITaskComponent
    {
        string Display();
        bool IsComplete();


    }
}
