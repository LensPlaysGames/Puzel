using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U_Puzel
{
    public class Player : MonoBehaviour, IPlayerMove
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

        [SerializeField]
        private bool moving;
        [SerializeField]
        private Vector3 cachedInput;

        public void Move(Vector3 input, float speed)
        {
            cachedInput = input;

            if (Mathf.Abs(rb.velocity.x) < Mathf.Abs(input.x * speed * 2))
            {
                rb.velocity = new Vector2(input.x * speed, rb.velocity.y);
            }
        }

        private void FixedUpdate()
        {
            if (cachedInput != Vector3.zero) { moving = true; }
            else { moving = false; }
            MultiplyFall();
        }

        private void MultiplyFall()
        {
            if (!moving) // Slide Protection
            {
                rb.velocity *= new Vector2(.9f, 1);
            }
            else if (moving && rb.velocity.y < 3f) // Slow Fall if Moving in Air
            {
                Debug.Log("Slowing Fast!");
                rb.velocity *= new Vector2(1, .9f);
            }
            else if (!moving && rb.velocity.y < 3f) // Fall Fast if Not Moving
            {
                Debug.Log("Falling Fast!");
                rb.velocity *= new Vector2(1, 1.8f);
            }
        }
    }
}

