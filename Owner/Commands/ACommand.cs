using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Owner.Commands
{
    public abstract class ACommand : ICommand
    {
        private byte id;
        private byte[] buffer;
        private BinaryWriter writer;

        public ACommand(byte id, int size)
        {
            this.id = id;
            buffer = new byte[size];

            writer = new BinaryWriter(new MemoryStream(buffer));
            writer.Write(id);
        }

        #region AppendParam
        protected void AppendParam(byte b)
        {
            writer.Write(b);
        }

        protected void AppendParam(short s)
        {
            writer.Write(s);
        }

        protected void AppendParam(int i)
        {
            writer.Write(i);
        }

        protected void AppendParam(long l)
        {
            writer.Write(l);
        }

        protected void AppendParam(double d)
        {
            writer.Write(d);
        }

        protected void AppendParam(string s)
        {
            writer.Write(s);
        }
        #endregion

        public abstract byte[] GetBuffer();

        protected byte[] Buffer
        {
            get{ return Buffer;}
        }
    }
}
