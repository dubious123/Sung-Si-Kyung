using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Data
{
    public static class Librarys
    {
        static HashSet<BaseLibrary> _librarySet;
        static Librarys()
        {
            _librarySet = new HashSet<BaseLibrary>();
            _librarySet.Add(new ImageLibrary());         
        }

        public static T Find<T>(string id) where T : Data
        {
            Data book;
            foreach(BaseLibrary library in _librarySet)
            {
                book = library.FindBook(id);
                if(book != null) { return book as T; }
            }
            return null;

            //if (dicTotal[id] is Image) { return ImageLibrary.GetImage(id).load() as T; }
            //else
            //    return default;

        }
    }
}
