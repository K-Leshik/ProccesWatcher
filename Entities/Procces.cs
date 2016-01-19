using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Procces
    {
        private Int32 PID { get; }
        private String Name { get; }
        private DateTime BeginDate { get; }
        private DateTime EndDate { get; }

        public Procces(Int32 pid, String name, DateTime begin_date, DateTime end_date) 
        {
            PID = pid;
            Name = name;
            BeginDate = begin_date;
            EndDate = end_date;
        }
    }
}
