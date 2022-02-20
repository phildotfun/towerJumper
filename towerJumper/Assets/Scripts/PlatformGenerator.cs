using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class PlatformGenerator : MonoBehaviour
{
    public string filename;
    public GameObject platform;
    private Collider2D coll;

    private float yOffset;
    private float xOffset;

    //rotation angle
    public float rotation;

    private string content;

    public GameObject tower;



    void Start()
    {
        coll = platform.GetComponent<Collider2D>();
        yOffset = coll.bounds.size.y * 2;
        xOffset = coll.bounds.size.x;

        ReadFile();
        MakeParentLevel(CountRows());

    }

    void Update()
    {

    }

    /// <summary>
    /// Open text file and read it's content
    /// Save to content string
    /// </summary>
    private string ReadFile()
    {
        StreamReader reader = new StreamReader(filename);
        return content = reader.ReadToEnd();
    }

    /// <summary>
    /// Checks to see how many rows there are in the text file
    /// </summary>
    /// <returns></returns>
    public int CountRows()
    {
        char[] newLineChar = { '\n' };
        string[] level = content.Split(newLineChar);

        //find how many line breaks there are
        //each line break will create one null level
        char lineChar = '\n';
        int levelCount = content.Count(f => (f == lineChar));
        return levelCount;
    }




    /*        for (int i = levelCount; i > 0; i--)
            {
                MakeRow(level[i], i);
            }*/

    /*    void MakeRow(string rowStr, float y)
        {
            char[] rowArray = rowStr.ToCharArray();

            for (int x = 0; x < rowArray.Length; x++)
            {

                nullLevel.transform.position = new Vector3(0, )
            }
        }*/

    void MakeParentLevel(int d)
    {
        for (int i = d; i > 0; i--)
        {
            GameObject parentLevel = Instantiate(Resources.Load("Level")) as GameObject;
            parentLevel.transform.position = new Vector3(0, i);
            parentLevel.name = "Level " + i;
        }
    }
}

