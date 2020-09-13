using UnityEngine;

namespace U_Puzel
{
    public interface IPlayerMove
    {
        void Move(Vector3 input, float speed);
        void Jump(float jumpForce);
    }
}

