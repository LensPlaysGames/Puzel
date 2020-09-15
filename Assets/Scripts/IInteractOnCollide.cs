using UnityEngine;

namespace U_Puzel
{
    public interface IInteractOnCollide
    {
        void OnCollisionEnter2D(Collision2D collider);
        void OnCollisionExit2D(Collision2D collider);
    }

}