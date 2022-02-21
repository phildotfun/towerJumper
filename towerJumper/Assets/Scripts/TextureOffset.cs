using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureOffset : MonoBehaviour
{
    // Scroll main texture based on time
    public float turnSpeed = 2f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A))
        {
            turnSpeed++;
            rend.material.mainTextureOffset = new Vector2(turnSpeed, 0);


        }
        else if (Input.GetKey(KeyCode.D))
        {
            turnSpeed--;
            rend.material.mainTextureOffset = new Vector2(turnSpeed, 0);

        }

    }
}
