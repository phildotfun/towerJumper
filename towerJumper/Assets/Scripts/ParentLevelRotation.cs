using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentLevelRotation : MonoBehaviour
{
    //Rotate the parent level to equal the rotation of the tower

    [SerializeField] GameObject tower;

    public void Start()
    {
        tower = GameObject.Find("Tower");
    }


    void FixedUpdate()
    {
        Quaternion towerRotation = tower.GetComponent<Transform>().rotation;
        transform.rotation = towerRotation;

    }
}
