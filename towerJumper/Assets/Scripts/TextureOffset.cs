using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureOffset : MonoBehaviour
{
    // Scroll main texture based on time
    public float turnSpeed = 2f;
    public float speed = 0f;
    Renderer rend;

    private Material material;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        float OffsetX = Time.time * speed;
        material.mainTextureOffset = new Vector2(OffsetX, 0);

    }
}
