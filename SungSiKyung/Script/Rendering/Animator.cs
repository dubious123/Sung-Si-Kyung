using System;
using System.Collections.Generic;
using System.Text;
using SungSiKyung.Data;
using SungSiKyung.Script.Content;

namespace SungSiKyung.Script.Rendering
{
    public class Animator
    {
        string Name;
        int _currentTick;
        int ImgCount = 0; // 이미지 개수
        int n = 0;

        RenderData RenderingData;
        List<RenderData> RenderingDatas = new List<RenderData>();

        public Animator(string name) // 인자 있음!
        {
            Name = name;

            _currentTick = Environment.TickCount;
            RenderingData = Librarys.Find<Image>("Player_idle1");
            foreach (String key in ImageLibrary._imageDict.Keys)
            {
                if (key.Contains(Name))
                {
                    RenderingDatas.Add(Librarys.Find<Image>(key));
                    ImgCount++;
                }
            }
            /*
            foreach(KeyValuePair<string, Image> items in ImageLibrary._imageDict)
            {
                if (items.Key.Contains(Name)){
                    RenderingDatas.Add(items.Value);
                    ImgCount++;
                }
            }
            */
            RenderingData = RenderingDatas[n];
            //RenderingData = Librarys.Find<Image>("Player_idle1");
        }

        public RenderData ChangeImage()
        {
            if (Environment.TickCount - _currentTick > 200)
            {
                n = (n + 1) % ImgCount;
                RenderingData = RenderingDatas[n];
                _currentTick = Environment.TickCount;
            }
            return RenderingData;
        }
    }
}