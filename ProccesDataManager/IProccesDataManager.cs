using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace ProccesDataManager
{
    public interface IProccesDataManager
    {
        void WriteBeginProcces(Int32 pid, String name, DateTime date);
        void WriteEndProcces(Int32 pid, String name, DateTime date);
        IEnumerable<Procces> Read(DateTime begin_date, DateTime end_date);
    }
}
