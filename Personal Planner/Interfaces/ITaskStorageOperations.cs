using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Planner.Interfaces
{
    public interface ITaskStorageOperations
    {
        void SaveTask(string filePathWriteTo);
        void RemoveTask(string filePathRemoveFrom,string filePathWriteTo);
        void RemoveExpiredTask();
    }
}
