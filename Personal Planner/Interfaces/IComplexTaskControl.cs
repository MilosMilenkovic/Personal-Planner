using Personal_Planner.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Planner.Interfaces
{
    public interface IComplexTaskControl
    {
        void Add(SimpleTask component);
        void Remove(SimpleTask component);

    }
}
