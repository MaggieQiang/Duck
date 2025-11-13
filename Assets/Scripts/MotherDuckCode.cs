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

    private int fishScore = 0; //is this the same as fish_count?
    public BabyDucksCode babyDucks;  


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

    public void IncreaseScore (int value)
    {
        fishScore += value;
        Debug.Log("fish eaten: " + value);

        //this adds a babyDuck whenever fishScore is 2
        if (fishScore >= 2)
        {
            if (babyDucks != null)
                babyDucks.addDuck();
            else
                Debug.LogWarning("MotherDuckCode: babyDucks reference is not assigned in the Inspector.");

            fishScore -= 2; //resetes score to 0
        }
    }
}