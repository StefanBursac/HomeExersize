﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class Person
    {
        public string name = "Stefan";

          public string Name
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


    }
}
