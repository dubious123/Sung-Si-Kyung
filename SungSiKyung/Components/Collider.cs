using SungSiKyung.Data;
using SungSiKyung.Script.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SungSiKyung.Components
{
    public class Collider : BaseComponent
    {
        string id = "Collider";
        public GameObject gameObject;
        HashSet<Vector2Int> _colliderDots = new HashSet<Vector2Int>();
        public HashSet<Vector2Int> ColliderOffsets = new HashSet<Vector2Int>();

        public HashSet<Vector2Int> ColliderDots 
        {
            get 
            {
                _colliderDots = (from pos in ColliderOffsets
                                select pos + Vector2Int.RoundToInt(gameObject.Transform.Position)).ToHashSet<Vector2Int>();
                return  _colliderDots; 
            } 
        }
        public float ElasticModulus;
        public event Action<GameObject> CollisionEvent ;
        public Collider(GameObject go,float elastic)
        {
            CollisionEvent += (GameObject go) => go.Velocity *= -ElasticModulus;
            gameObject = go;
            ElasticModulus = elastic;
        }
        public void InvokeColliderEvent(GameObject go)
        {
            CollisionEvent.Invoke(go);
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
