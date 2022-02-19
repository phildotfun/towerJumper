using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlatformGenerator : MonoBehaviour
{
    public string filename;
    public GameObject platform;
    private Collider2D coll;

    private float yOffset;
    private float xOffset;



    void Start()
    {
        coll= GetComponent<Collider2D>();
        yOffset = coll.bounds.size.y;
        xOffset = coll.bounds.size.x;

        ReadFile();

    }

    void Update()
    {
        
    }

    /// <summary>
    /// Open text file and read it's content
    /// Save to content string
    /// </summary>
    void ReadFile()
    {
        StreamReader reader = new StreamReader(filename);
        string content = reader.ReadToEnd();
        reader.Close();
    }

    void BuildLevel()
    {

    }
}
