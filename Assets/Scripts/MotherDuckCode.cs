using UnityEngine;
using UnityEngine.InputSystem;

public class MotherDuckCode : MonoBehaviour
{
    [SerializeField] private float speed = 6f;

    private float movementX;
    private float movementY;

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Move(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();
        movementX = v.x;
        movementY = v.y;
    }

    void Update()
    {
        animator.SetBool("isMoving", movementX != 0f || movementY != 0f);
        if (movementX != 0f)
        {
            spriteRenderer.flipX = movementX < 0f;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movementX * speed, movementY * speed);
    }
}