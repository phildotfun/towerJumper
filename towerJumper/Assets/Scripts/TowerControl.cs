using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControl : MonoBehaviour
{


  
    private Vector3 rotation;

    public PlatformGenerator platformGen;

    public float towerHeight;

    public float turnSpeed = 0f;

    private GameObject player;

    private Rigidbody rb;
    public float torque;

    // Start is called before the first frame update
    public void Start()
    {
        int yScale = platformGen.CountRows();
        MovePivotPoint(yScale);
        SetHeight(yScale);

        player = GameObject.Find("Player");

        rb = GetComponent<Rigidbody>(); 

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.up * torque * turn);
    }

    /// <summary>
    /// Moves the pivot point to the bottom of the tower
    /// </summary>
    void MovePivotPoint(float y)
    {
        transform.position = new Vector2(0, y * -.15f);
    }

    /// <summary>
    /// The height of the tower is based on how many rows there are
    /// </summary>
    /// <param name="towerHeight"></param>
    void SetHeight(float towerHeight)
    {
        transform.localScale = new Vector3(transform.localScale.x, towerHeight / 2, transform.localScale.x);
    }

    void ResetTower()
    {

    }

}

