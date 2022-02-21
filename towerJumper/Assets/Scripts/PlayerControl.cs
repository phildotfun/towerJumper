using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControl : MonoBehaviour
{

    public AudioSource jumpSound;

    public float timeCount = 0f;

    public float blockRot = 0f;

    public float torque = 0f;
    

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

        float turn = Input.GetAxis("Horizontal");
        Quaternion newRotation = Quaternion.Euler(0, 0, torque * -turn);
        transform.rotation = newRotation;

    }



    /// <summary>
    /// Uses a boxcast that is slightly lower that only
    /// interacts with the platform.
    /// </summary>
    /// <returns></returns>
    private bool IsGrounded()
    {
        return Physics.Raycast(coll.bounds.center, -transform.up, 2f, platformLayerMask);
    }

    /// <summary>
    /// Check if player presses space bar
    /// and if IsGrounded is true.
    /// </summary>
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            jumpSound.Play();   
            Vector2 movement = new Vector2(0, 1);
            rb.AddForce(movement * speed, ForceMode.Impulse);
            
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 firstPosition;
        firstPosition = new Vector3(0, 2.5f, -5.18f);
        transform.position = firstPosition;
    }
}
