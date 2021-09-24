using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SungSiKyung.Script.Utils;

namespace SungSiKyung.Data
{
    public class Image : RenderData
    {
        int _width;
        int _hight;
        List<Pixel> _pixels;
        public List<Pixel> Pixels { get { return _pixels; } }

<<<<<<< HEAD

        public int[,] inputPixel;

        public Image(int[,] inputPixel)
=======
        public Image(List<Pixel> pixelList, GameObject go = null)
>>>>>>> 1a09cfb49b26ec53cc7e2982701a1a7233896536
        {
            _pixels = new List<Pixel>();
            _pixels = pixelList;
        }
        //Test
        public Image(int[,] arr)
        {
            _pixels = new List<Pixel>();
            int _width = arr.GetLength(1);
            int _hight = arr.GetLength(0);
            int _offsetX = -_width / 2;
            int _offsetY = -_hight / 2;
            for(int y = 0; y < _hight; y++)
            {
                for(int x = 0; x < _width; x++)
                {
                    _pixels.Add(new Pixel(new Vector2Int(x + _offsetX, y + _offsetY), arr[y, x] == 0 ? ' ' : '■'));
                }
            }
        }
        public void PrintImage(Vector2Int center,GameObject go = null)
        {
            foreach (Pixel pixel in _pixels)
            {
                pixel.Print(center,go);
            }
        }
        public void PrintImageWithCollider(Vector2Int center, GameObject go)
        {
            foreach (Pixel pixel in _pixels)
            {
                pixel.Print(center,go);
            }
        }
        public override Data load()
        {
            return this;
        }
    }
}
