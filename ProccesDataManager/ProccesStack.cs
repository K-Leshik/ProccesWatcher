using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace ProccesDataManager
{
    class ProccesStack
    {
        class TmpProcces
        {
            public Int32 pid;
            public String name;
            public DateTime begin_date;
        }

        private Dictionary<int, TmpProcces> porcces_stack;

        public ProccesStack()
        {
            porcces_stack = new Dictionary<int, TmpProcces>();
        }

        public void Push(Int32 pid, String name, DateTime begin_date)
        {
            TmpProcces p = new TmpProcces();
            p.pid = pid;
            p.name = name;
            p.begin_date = begin_date;
            porcces_stack.Add(pid, p);
        }

        public Procces Pop(Int32 pid, String name, DateTime end_date)
        {
            TmpProcces tmp_p;
            Procces p;
            if (porcces_stack.TryGetValue(pid, out tmp_p))
            {
                p = new Procces(tmp_p.pid, tmp_p.name, tmp_p.begin_date, end_date);
            }
            else
            {
                p = new Procces(pid, name, DateTime.Now.AddMilliseconds(-Environment.TickCount), end_date);
            }
            return p;
        }
    }
}
