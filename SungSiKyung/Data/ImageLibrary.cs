using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Data
{
    public class ImageLibrary :BaseLibrary
    {

        public static int[,] idle1 = {{ 0, 1, 1, 1, 1 },{0,1,1,1,1},{0,1,1,1,1},{0,1,1,1,1},{0,0,1,0,0},{0,1,1,1,0},
            {1,0,1,0,1},{1,0,1,0,1},{0,0,1,0,0},{0,1,0,1,0},{1,0,0,0,1},{1,0,0,0,1} };
        public static int[,] idle2 = {{0,0,0,0,0},{0,1,1,1,1},{ 0,1,1,1,1},{ 0,1,1,1,1},{ 0,1,1,1,1},{ 0,0,1,0,0},
            { 0,1,1,1,0},{ 1,0,1,0,1},{ 1,0,1,0,1},{ 0,1,0,1,0},{ 1,0,0,0,1},{ 1,0,0,0,1}};
        Dictionary<string, Image> _imageDict = new Dictionary<string, Image>();

        public ImageLibrary()
        {
            _imageDict.Add("idle1",new Image(idle1));
            _imageDict.Add("idle2",new Image(idle2));
        }


        public override Data FindBook(string id)
        {
            if (_imageDict.ContainsKey(id)) { return _imageDict[id]; }
            else { return null; }           
        }
    }
}
