using SungSiKyung.Components;
using SungSiKyung.Data;

namespace SungSiKyung.Script.Controller
{

    public class PlayerController : BaseComponent
    {
        string id = "PlayerController";
        public GameObject gameObject;
        public float MaxVelocity_Up = 3;
        public float MaxVelocity_Side = 1;
        public PlayerController(GameObject go)
        {
            gameObject = go;
        }
        public void MoveRight()
        {
            gameObject.Velocity.x += Managers.Managers.TimingMgr.DeltaTime * 30;
        }
        public void MoveLeft()
        {
            gameObject.Velocity.x -= Managers.Managers.TimingMgr.DeltaTime * 30;
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
