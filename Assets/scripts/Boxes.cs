using UnityEngine;
using System.Collections;

public class Boxes : MonoBehaviour {

	float fall = 0;
    float fallspeed = 1;
	public static int gridWeight = 10;
	public static int gridHeight = 20;
	

	void Start () {
        //if (!isValidPosition()) {
        //	Application.LoadLevel(0);
        //	Destroy(gameObject);
        //}
    }

	void Update() {
		//*******************************hareket kodları**********************************************//
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			transform.position += new Vector3(1, 0, 0);
            if (CheckIsValidPosition())
            {

            } else
            {
                transform.position += new Vector3(-1, 0, 0);
            }
                
        }

		else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.position += new Vector3(-1, 0, 0);
            if (CheckIsValidPosition())
            {

            }
            else
            {
                transform.position += new Vector3(1, 0, 0);
            }
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, 90);
            if (CheckIsValidPosition())
            {

            }
            else
            {
                transform.Rotate(0, 0, -90);
            }
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - fall >= fallspeed) {
			transform.position += new Vector3(0, -1 , 0);
            if (CheckIsValidPosition())
            {

            }
            else
            {
                transform.position += new Vector3(0, 1, 0);
            }
            fall = Time.time;
        }
	}
    //*******************************hareket kodları**********************************************//
    bool CheckIsValidPosition()
    {
        foreach (Transform mino in transform)
        {
            Vector2 pos = FindObjectOfType<Game>().Round(mino.position);
            if (FindObjectOfType<Game>().CheckIsInsideGrid (pos) == false )
            {
                return false;
            }
        }
        return true;
    }
 //   bool isValidPosition() {        
	//	foreach (Transform child in transform) {
	//		Vector2 v = round(child.position);
	//		if (!isInsideGrid(v))
	//			return false;
	//		if (grid[(int)v.x, (int)v.y] != null &&
	//		    grid[(int)v.x, (int)v.y].parent != transform)
	//			return false;
	//	}
	//	return true;
	//}

	//void GridUpdate() {
	//	for (int y = 0; y < gridHeight; ++y)
	//		for (int x = 0; x < gridWeight; ++x)
	//			if (grid[x, y] != null)
	//				if (grid[x, y].parent == transform)
	//					grid[x, y] = null;
	//	foreach (Transform child in transform) {
	//		Vector2 v = round(child.position);
	//		grid[(int)v.x, (int)v.y] = child;
	//	}        
	//}
	//public static Vector2 round(Vector2 v) {
	//	return new Vector2(Mathf.Round(v.x), Mathf.Round(v.y));
	//}
	
	//public static bool isInsideGrid(Vector2 pos) {
	//	return ((int)pos.x >= 0 && (int)pos.x < gridWeight && (int)pos.y >= 0);
	//}
	
	//public static void Delete(int y) {
	//	for (int x = 0; x < gridWeight; ++x) {
	//		Destroy(grid[x, y].gameObject);
	//		grid[x, y] = null;
	//	}
	//}

	//public static bool isFull(int y) {
	//	for (int x = 0; x < gridWeight; ++x)
	//		if (grid[x, y] == null)
	//			return false;
	//	return true;
	//}

	//public static void DeleteRow() {
	//	for (int y = 0; y < gridHeight; ++y) {
	//		if (isFull(y)) {
	//			Delete(y);
	//			RowDownAll(y+1);
	//			--y;
	//		}
	//	}
	//}
	
	//public static void RowDown(int y) {
	//	for (int x = 0; x < gridWeight; ++x) {
	//		if (grid[x, y] != null) {
	//			grid[x, y-1] = grid[x, y];
	//			grid[x, y] = null;
	//			grid[x, y-1].position += new Vector3(0, -1, 0);
	//		}
	//	}
	//}
	
	//public static void RowDownAll(int y) {
	//	for (int i = y; i < gridHeight; ++i)
	//		RowDown(i);
	//}
}
