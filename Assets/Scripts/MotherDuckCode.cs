using UnityEngine;
using UnityEngine.InputSystem;

public class MotherDuckCode : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private float movementX;
    private float movementY;

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private int fishScore;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void OnMove(InputValue value)
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
        Debug.Log(rb.linearVelocity);
    }

    public void AddFish (int value)
    {
        fishScore += value;
        Debug.Log(value);
    }
}