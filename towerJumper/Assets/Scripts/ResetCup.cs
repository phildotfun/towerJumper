using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCup : MonoBehaviour
{
    public GameObject cup;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = cup.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        cup.transform.rotation = Quaternion.identity;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

}
