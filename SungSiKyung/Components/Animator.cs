using System;
using System.Collections.Generic;
using System.Text;
using SungSiKyung.Components;
using SungSiKyung.Data;
using SungSiKyung.Scene;
using SungSiKyung.Script.Content;

namespace SungSiKyung.Script.Rendering
{
    public class Animator : BaseComponent
    {
        string id = "Animator";
        string Name;
        int ImgCount = 0; // 이미지 개수
        int n = 0;

        enum ImageDictKeys
        {
            Player_idle1,
            Player_idle2,
            Enemy_idle1,
            Enemy_idle2
        }

        public Animator(GameObject unit, string name) // 인자 있음!
        {
            Name = name;
            unit._currentTick = Environment.TickCount;

            foreach(ImageDictKeys key in Enum.GetValues(typeof(ImageDictKeys))){
                if (key.ToString().Contains(Name))
                {
                    unit.RenderingDatas.Add(Librarys.Find<Image>(key.ToString()));
                    ImgCount++;
                }
            }
            if (ImgCount > 0)
                unit.RenderingData = unit.RenderingDatas[n];
            else
                unit.RenderingData = Librarys.Find<Image>("Error");
        }
        public static void ApplyAnimator(BaseScene scene)
        {
            foreach (GameObject unit in scene.DynamicSet)
            {
                int _n = unit.GetComponent<Animator>().n;
                int _imgCount = unit.GetComponent<Animator>().ImgCount;
                if (Environment.TickCount - unit._currentTick > 200)
                {
                    if (_imgCount > 0)
                    {
                        _n = (_n + 1) % _imgCount;
                        unit.GetComponent<Animator>().n = _n;
                        unit.RenderingData = unit.RenderingDatas[_n];
                    }
                    unit._currentTick = Environment.TickCount;
                }
            }
        }

        public override bool Equals(object obj)
        {
            return obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}