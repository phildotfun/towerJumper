using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControl : MonoBehaviour
{

    [SerializeField] private LayerMask platformLayerMask;

    private Rigidbody rb;
    private CapsuleCollider coll;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //player jumps
        Jump();
        
        Debug.DrawRay(coll.bounds.center, -transform.up * .75f, Color.red);
    }

    /// <summary>
    /// Uses a boxcast that is slightly lower that only
    /// interacts with the platform.
    /// </summary>
    /// <returns></returns>
    private bool IsGrounded()
    {
        return Physics.Raycast(coll.bounds.center, -transform.up, .74f, platformLayerMask);
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
            rb.AddForce(movement * speed, ForceMode.Impulse);
        }

    }


}
