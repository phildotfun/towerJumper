using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControl : MonoBehaviour
{


    public float height;
    private Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -height * Time.deltaTime);
           

        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up,  height * Time.deltaTime);

        }
    }

}

