using UnityEngine;

namespace U_Puzel
{
    public class PlayerInput : MonoBehaviour
    {
        #region Input Init

        public InputManager inputs;
        private void Awake()
        {
            inputs = new InputManager();
        }
        private void OnEnable()
        {
            inputs.Enable();
        }
        private void OnDisable()
        {
            inputs.Disable();
        }

        #endregion

        IPlayerMove player;

        [Range(.1f, 36f)]
        public float playerSpeed = 9f;
        [Range(.1f, 36f)]
        public float jumpForce = 9f;

        [Range(0.1f, 1.8f)]
        public float groundDist = .27f;
        public LayerMask ground;

        Transform groundPoint;

        private void Start()
        {
            player = GetComponent<IPlayerMove>();
            groundPoint = transform.Find("GroundCheck");
        }
        private void Update()
        {
            GetInput();
        }

        public void GetInput()
        {
            Vector3 input = GetMovement();
            player.Move(input, playerSpeed);

            if (Physics2D.OverlapCircle(groundPoint.position, groundDist, ground))
            {
                if (inputs.player.Jump.triggered)
                {
                    player.Jump(jumpForce);
                }
            }
        }

        public Vector3 GetMovement()
        {
            Vector3 move = new Vector3();

            move.x = inputs.player.Movement.ReadValue<float>();

            return move;
        }
    }
}