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
        states[5, 5] = State.infected;
        states[27,47] = State.infected;
        states[38, 38] = State.doctor;
        states[26, 15] = State.doctor;
        states[49, 5] = State.doctor;
        states[4, 47] = State.doctor;
        states[6, 30] = State.doctor;
        states[28, 31] = State.doctor;

    }

    // Update is called once per frame
    void Update()
    {
        RenderGrid();
    }


    void VirusSpread()
    {
        for (int y = 1; y <= size.y; y++)
        {
            for (int x = 1; x <= size.x; x++)
            {
                State currentState = states[x - 1, y - 1];

                switch (currentState)
                {
                    case State.infected:
                        
                        break;

                    case State.doctor:

                        break;
                }

            }

        }
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
