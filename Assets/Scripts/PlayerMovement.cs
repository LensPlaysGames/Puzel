using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public InputManager inputManager;

    private Rigidbody2D rb;

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private float groundedHeight;
    [SerializeField]
    private LayerMask ground;

    private Transform groundPoint;
    private Vector3 input;

    void Awake()
    {
        inputManager = new InputManager();

        rb = GetComponent<Rigidbody2D>();
        groundPoint = transform.Find("GroundCheck");
    }

    void OnEnable()
    {
        inputManager.player.Enable();
    }

    void OnDisable()
    {
        inputManager.player.Disable();
    }

    void Update()
    {
        GetInput();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        transform.position += input * moveSpeed * Time.deltaTime;
    }

    void Jump()
    {
        rb.AddForce(new Vector3(rb.velocity.x, jumpForce, 0), ForceMode2D.Impulse);
    }

    void GetInput()
    {
        input.x = inputManager.player.Movement.ReadValue<float>();

        if (Physics2D.OverlapCircle(groundPoint.position, groundedHeight, ground))
        {
            if (inputManager.player.Jump.triggered) { Jump(); }
        }
    }
}
