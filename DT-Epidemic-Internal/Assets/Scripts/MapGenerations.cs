using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerations : MonoBehaviour
{
    [SerializeField]
    Vector2Int size;


    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateMap()
    {
        GameObject parent = new GameObject("Grid");

        for (int y = 1; y <= size.y; y++)
        {
            for (int x = 1; x<= size.x; x++)
            {
                GameObject obj = Instantiate(Resources.Load("cell") as GameObject);
                obj.name = "Cell: (" + x + "," + y + ")";
                obj.transform.position = new Vector2(x, y);
                obj.transform.SetParent(parent.transform);
                //Debug.Log("Cell: (" + x + "," + y + ")");
            }
        }
    }


}
