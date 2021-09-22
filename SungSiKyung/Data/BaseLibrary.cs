using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Data
{
    public abstract class BaseLibrary
    {
        public abstract Data FindBook(string id);
    }
}
