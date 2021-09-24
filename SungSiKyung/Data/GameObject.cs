using SungSiKyung.Components;
using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Data
{
    public class GameObject
    {
        public _Transform Transform = new _Transform();
        public Vector2 Velocity = new Vector2(0,0);
        public RenderData RenderingData;
        HashSet<BaseComponent> Components = new HashSet<BaseComponent>(); 
        public void AddComponent(BaseComponent component)
        {
            if (!Components.Contains(component)) { Components.Add(component); }
        }
        public T GetComponent<T>() where T : BaseComponent
        {
            foreach (BaseComponent component in Components)
            {
                if(component is T) { return component as T; }
            }
            return null;
        }
        public void AddComponent<T>(T component) where T : BaseComponent
        {
            if (HasComponent<T>()) { return; }
            Components.Add(component);
        }
        public bool HasComponent<T>()
        {
            foreach (BaseComponent component in Components)
            {
                if (component is T) { return true; }
            }
            return false;
        }
    }
}
