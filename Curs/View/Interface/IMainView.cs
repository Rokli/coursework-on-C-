﻿using Curs.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.View.Interface
{
    public  interface IMainView
    {
        Button InputPanel { set; }

        LeftButton InputControls { set; }
    }
}