using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControl : MonoBehaviour
{

    [SerializeField] private LayerMask platformLayerMask;

    private Rigidbody2D rb;
    private BoxCollider2D coll;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //player jumps
        Jump();
    }

    /// <summary>
    /// Uses a boxcast that is slightly lower that only
    /// interacts with the platform.
    /// </summary>
    /// <returns></returns>
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, platformLayerMask);
    }

    /// <summary>
    /// Check if player presses space bar
    /// and if IsGrounded is true.
    /// </summary>
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Vector2 movement = new Vector2(0, 1);
            rb.AddForce(movement * speed, ForceMode2D.Impulse);
        }

    }

}
