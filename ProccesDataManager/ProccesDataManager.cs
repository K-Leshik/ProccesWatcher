using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.IO;

namespace ProccesDataManager
{
    class ProccesDataManager : IProccesDataManager
    {
        static private IProccesDataManager instance = null;
        private const string dir_path = @"\ProcW";
        private string full_dir_path;

        private ProccesDataManager()
        {
            full_dir_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + dir_path;
        }

        static public IProccesDataManager GetInstance()
        {
            if(instance == null)
            {
                instance = new ProccesDataManager();
            }
            return instance;
        }

        public IEnumerable<Procces> Read(DateTime begin_date, DateTime end_date)
        {
            if (full_dir_path == null ||
                full_dir_path == String.Empty ||
                !Directory.Exists(full_dir_path))
            {
                throw new DirectoryNotFoundException();
            }

            List<Procces> procces_list = new List<Procces>();
            DirectoryInfo dir_info = new DirectoryInfo(full_dir_path);
            long ts_begin_date = begin_date.Ticks;
            long ts_end_date = end_date.Ticks;
            foreach (FileInfo fi in dir_info.GetFiles())
            {
                if (fi.CreationTime.Ticks <= ts_end_date &&
                    fi.LastWriteTime.Ticks >= ts_begin_date)
                {
                    using (BinaryReader reader = new BinaryReader(new FileStream(fi.Name, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                    {
                        while (reader.BaseStream.Position != reader.BaseStream.Length)
                        {
                            ProccesStack ps = new ProccesStack();
                            int pid = reader.ReadInt32();
                            string name = reader.ReadString();
                            DateTime date = new DateTime(reader.ReadInt64());
                            bool end_procces = reader.ReadBoolean();
                            if (end_procces)
                            {
                                procces_list.Add(ps.Pop(pid, name, date));
                            }
                            else
                            {
                                ps.Push(pid, name, date);
                            }
                        }
                    }
                }
            }
            
            return procces_list;
        }

        public void WriteBeginProcces(int pid, string name, DateTime date)
        {
            throw new NotImplementedException();
        }

        public void WriteEndProcces(int pid, string name, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
