using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Data
{
    public class ImageLibrary :BaseLibrary
    {

        public static int[,] pixel1 = {{ 0, 1, 1, 1, 1 },{0,1,1,1,1},{0,1,1,1,1},{0,1,1,1,1},{0,0,1,0,0},{0,1,1,1,0},
            {1,0,1,0,1},{1,0,1,0,1},{0,0,1,0,0},{0,1,0,1,0},{1,0,0,0,1},{1,0,0,0,1} };
        public static int[,] pixel2 = {{0,0,0,0,0},{0,1,1,1,1},{ 0,1,1,1,1},{ 0,1,1,1,1},{ 0,1,1,1,1},{ 0,0,1,0,0},
            { 0,1,1,1,0},{ 1,0,1,0,1},{ 1,0,1,0,1},{ 0,1,0,1,0},{ 1,0,0,0,1},{ 1,0,0,0,1}};
        Dictionary<string, Image> _imageDict = new Dictionary<string, Image>();

        public ImageLibrary()
        {
            _imageDict.Add("idle1",new Image(pixel1));
            _imageDict.Add("idle2",new Image(pixel2));
        }


        public override Data FindBook(string id)
        {
            if (_imageDict.ContainsKey(id))
            {
                Image input = new Image(_imageDict[id].inputPixel);
                return input;
            }

            else
                return null;
        }
    }
}
