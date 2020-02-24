using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerations : MonoBehaviour
{
    [SerializeField]
    Vector2Int size;
    SpriteRenderer[,] spriteRenderers;
    public enum State
    {
        clean = 0,
        infected,
        doctor,
        hospital,
        military
    }
    State[,] states;

    [SerializeField]
    Color32[] colors;



    // Start is called before the first frame update
    void Start()
    {
        GenerateMap();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderGrid();
    }

    void RenderGrid()
    {
        for (int y = 1; y <= size.y; y++)
        {
            for (int x = 1; x <= size.x; x++)
            {
                spriteRenderers[x - 1, y - 1].color = colors[(int)states[x - 1, y - 1]];
            }

        }

    }


    void GenerateMap()
    {
        GameObject parent = new GameObject("Grid");
        spriteRenderers = new SpriteRenderer[size.x, size.y];
        states = new State[size.x, size.y];

        for (int y = 1; y <= size.y; y++)
        {
            for (int x = 1; x<= size.x; x++)
            {
                GameObject obj = Instantiate(Resources.Load("cell") as GameObject);
                obj.name = "Cell: (" + x + "," + y + ")";
                obj.transform.position = new Vector2(x, y);
                obj.transform.SetParent(parent.transform);
                //Debug.Log("Cell: (" + x + "," + y + ")");

                spriteRenderers[x - 1, y - 1] = obj.GetComponent<SpriteRenderer>();

            }
        }
    }


}
