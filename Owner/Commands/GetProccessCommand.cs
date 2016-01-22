using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Owner.Commands
{
    public class GetProccessCommand : ACommand
    {
        private DateTime dt_from;
        private DateTime dt_to;

        public GetProccessCommand() :
            base(0x41, 17)
        {
        }

        public GetProccessCommand SetDateTimeFrom(DateTime dt)
        {
            dt_from = dt;
            return this;
        }

        public GetProccessCommand SetDateTimeTo(DateTime dt)
        {
            dt_to = dt;
            return this;
        }

        public override byte[] GetBuffer()
        {
            this.AppendParam(dt_from.Ticks);
            this.AppendParam(dt_to.Ticks);
            return this.Buffer;
        }
    }
}
