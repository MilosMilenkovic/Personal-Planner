﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Planner.Interfaces
{

    public interface ICardDisplay
    {
        Control MakeTaskCard(bool allowComplete, bool allowDelete);
    }
}
