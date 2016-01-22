using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Owner.Commands
{
    public interface ICommand
    {
        byte[] GetBuffer();
    }
}
