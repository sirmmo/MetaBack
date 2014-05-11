using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakLib
{
    public interface IStalker<T>
    {
        void Update(T new_t);
    }
}
