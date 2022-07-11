using System;
using System.Collections.Generic;
using System.Text;

namespace ShallowDeepCopy
{
    public interface IPrototype<T>
    {
        T ShallowCopy();
            
        T DeepCopy();

    }
}
