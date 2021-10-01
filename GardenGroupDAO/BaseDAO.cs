﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupDAO
{
    public abstract class BaseDAO
    {
        protected readonly MongoDB db;

        public BaseDAO()
        {
            db = MongoDB.GetInstance();
        }
    }
}
