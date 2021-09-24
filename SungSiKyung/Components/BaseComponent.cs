using System;
using System.Collections.Generic;
using System.Text;

namespace SungSiKyung.Components
{
    public abstract class BaseComponent
    {
        public abstract override int GetHashCode();
        public abstract override bool Equals(object obj);
    }
}
