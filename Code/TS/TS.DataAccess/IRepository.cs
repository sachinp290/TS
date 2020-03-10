﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.DataAccess
{
    public interface IRepository<T> where T : class
    {
        T Get(int id, bool isAll = 0);
    }
}
