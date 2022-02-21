using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControl : MonoBehaviour
{


  
    private Vector3 rotation;

    public PlatformGenerator platformGen;

   public float towerHeight;

    public float turnSpeed = 0f;

    // Start is called before the first frame update
    public void Start()
    {
        int yScale = platformGen.CountRows();
        MovePivotPoint(yScale);
        SetHeight(yScale);
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
           

        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

        }
    }

    /// <summary>
    /// Moves the pivot point to the bottom of the tower
    /// </summary>
    void MovePivotPoint(float y)
    {
        transform.position = new Vector2(0, y / 2);
    }

    /// <summary>
    /// The height of the tower is based on how many rows there are
    /// </summary>
    /// <param name="towerHeight"></param>
    void SetHeight(float towerHeight)
    {
        transform.localScale = new Vector3(transform.localScale.x, towerHeight / 2, transform.localScale.x);
    }

}

