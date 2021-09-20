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
        public static Dictionary<string, Data> dicTotal = new Dictionary<string, Data>()
        {

            {"idle1", ImageLibrary.GetImage("idle1") },
            {"idle2", new Image(ImageLibrary.pixel2) }
        };

        public static T Load<T>(string id) where T : Data
        {

            if (dicTotal[id] is Image) { return ImageLibrary.GetImage(id).load() as T; }
            else
                return default;

        }
    }
}
