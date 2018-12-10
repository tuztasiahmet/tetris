using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public static int gridWidth = 10;
    public static int gridHeight = 20;
    public GameObject[] boxList;
    public Transform spawnSpot;
    public static Transform[,] grid = new Transform[gridWidth, gridHeight];
    // Use this for initialization
    void Start () {
        SpawnNewBox();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Destroy(grid[0, 5].gameObject);
    }
    public void SpawnNewBox()
    {
        int i = Random.Range(0, boxList.Length);
        Instantiate(boxList[i], spawnSpot.position, Quaternion.identity);
    }

    public bool CheckIsInsideGrid (Vector2 pos)
    {
        return ((int)pos.x >= 0 && (int)pos.x < gridWidth && (int)pos.y >= 0);
    }
    
    public Vector2 Round (Vector2 pos)
    {
        return new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y));
    }

    
}
