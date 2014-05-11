using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakLib
{
    public interface IStalked<T>
    {
        void Subscribe(IStalker<T> element);
        void Unsubscribe(IStalker<T> element);
    }
}
