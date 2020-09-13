using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U_Puzel
{
    public class RedPlayer : MonoBehaviour, IPlayerMove
    {
        public Rigidbody2D rb;
        void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        public void Jump(float jumpForce)
        {
            rb.AddForce((Vector2.up * jumpForce), ForceMode2D.Impulse);
        }

        public void Move(Vector3 input, float speed)
        {
            rb.velocity += new Vector2(input.x, input.y) * speed;
        }
    }
}

