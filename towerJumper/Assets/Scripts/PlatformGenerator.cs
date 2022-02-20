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

    //content of the text file
    private string content;

    public GameObject tower;

    //paltforms will become a child of this level the number;
    public GameObject parentLevel;



    void Start()
    {
        coll = platform.GetComponent<Collider2D>();
        yOffset = coll.bounds.size.y * 2;
        xOffset = coll.bounds.size.x;

        ReadFile();
        MakeParentLevel(CountRows());
        MakeRow(CountRows());
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
        //find how many line breaks there are
        //each line break will create one null level
        char lineChar = '\n';
        int levelCount = content.Count(f => (f == lineChar));
        return levelCount;
    }

     void MakeRow(int rows)
     {
        char[] newLineChar = { '\n' };
        string[] levelRow = content.Split(newLineChar);
        

        for (int x = rows; x > 0; x--)
        {
            char[] rowArray = levelRow[x].ToCharArray();

            for (int y = 0; y < rowArray.Length - 1; y++)
            {
                char plat = rowArray[y];
                if (plat == 'X')
                {
                    {
                        GameObject platform = Instantiate(Resources.Load("Platform")) as GameObject;
                    }
                }
            }
        }
     }
    /// <summary>
    /// Create a empty parent that sits in center of tower
    /// Subtract 1 to account for array counting
    /// </summary>
    /// <param name="d"></param>
    void MakeParentLevel(int d)
    {
        for (int i = d - 1; i > 0; i--)
        {
            GameObject parentLevel = Instantiate(Resources.Load("Level")) as GameObject;
            parentLevel.transform.position = new Vector3(0, i);
            parentLevel.name = "Level " + i;
        }
    }
}

