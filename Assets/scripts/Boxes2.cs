using System;
using UnityEngine;
public class Boxes2 : MonoBehaviour {

	float fall = 0;
	public static int gridWeight = 10;
	public static int gridHeight = 40;
	public static Transform[,] grid = new Transform[gridWeight, gridHeight];
    public static double hiz ;

	void Start () {
        hiz = Click.hiz;
        if (!isValidPosition()) {
			//Application.LoadLevel(0);
			Destroy(gameObject);
		}
	}
    
    bool boolTimer = true;
    bool boolTimerY = true;
    bool boolTimerZ = true;
    void TouchScreenMovement()
    {
        if (Input.touchCount == 1)
        {
            //if (boolTimer == true)
            //{
            //    if (Mathf.FloorToInt(Input.touches[0].deltaPosition.x) > 50 || Mathf.FloorToInt(Input.touches[0].deltaPosition.x) < -50)
            //        transform.position += new Vector3(Input.touches[0].deltaPosition.x / Mathf.Abs(Input.touches[0].deltaPosition.x), 0, 0);

            //    if (isValidPosition())
            //        GridUpdate();
            //    else
            //    {
            //        if ((Mathf.FloorToInt(Input.touches[0].deltaPosition.x) > 0)) transform.position += new Vector3(-1, 0, 0);
            //        if ((Mathf.FloorToInt(Input.touches[0].deltaPosition.x) < 0)) transform.position += new Vector3(1, 0, 0);
            //    }
            //    boolTimer = false;
            //}

            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    boolTimerY = true;
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    if (boolTimerY == true)
                    {
                        if (Mathf.FloorToInt(touch.deltaPosition.y) > 60)
                        {
                            transform.Rotate(0, 0, -90);
                            if (isValidPosition())
                                GridUpdate();
                            else
                                transform.Rotate(0, 0, 90);

                            boolTimerY = false;
                        }
                    }
                    break;
                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    break;
            } //rotate (yukarı kaydırma) dokunmatik hareket

            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    boolTimerZ = true;
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    if (boolTimerZ == true)
                    {
                        if (Mathf.FloorToInt(touch.deltaPosition.y) < -45)
                        {
                            transform.position += new Vector3(0, Input.touches[0].deltaPosition.y / Mathf.Abs(Input.touches[0].deltaPosition.y ), 0);
                            boolTimerZ = false;
                            if (isValidPosition())
                            {
                                GridUpdate();
                            }
                            else
                            {
                                transform.position += new Vector3(0, 1, 0);
                                DeleteRow();
                                FindObjectOfType<SpawnBox2>().SpawnNewBox();
                                enabled = false;
                            }
                            transform.position += new Vector3(0, Input.touches[0].deltaPosition.y / Mathf.Abs(Input.touches[0].deltaPosition.y), 0);

                            if (isValidPosition())
                            {
                                GridUpdate();
                            }
                            else
                            {
                                transform.position += new Vector3(0, 1, 0);
                                DeleteRow();
                                FindObjectOfType<SpawnBox2>().SpawnNewBox();
                                enabled = false;
                            }
                            transform.position += new Vector3(0, Input.touches[0].deltaPosition.y / Mathf.Abs(Input.touches[0].deltaPosition.y), 0);

                            if (isValidPosition())
                            {
                                GridUpdate();
                            }
                            else
                            {
                                transform.position += new Vector3(0, 1, 0);
                                DeleteRow();
                                FindObjectOfType<SpawnBox2>().SpawnNewBox();
                                enabled = false;
                            }

                        }
                        else if (Mathf.FloorToInt(touch.deltaPosition.y) < -30)
                        {
                            transform.position += new Vector3(0, (Input.touches[0].deltaPosition.y / Mathf.Abs(Input.touches[0].deltaPosition.y) ), 0);
                            boolTimerZ = false;
                            if (isValidPosition())
                            {
                                GridUpdate();
                            }
                            else
                            {
                                transform.position += new Vector3(0, 1, 0);
                                DeleteRow();
                                FindObjectOfType<SpawnBox2>().SpawnNewBox();
                                enabled = false;
                            }
                            transform.position += new Vector3(0, (Input.touches[0].deltaPosition.y / Mathf.Abs(Input.touches[0].deltaPosition.y) ), 0);
                            if (isValidPosition())
                            {
                                GridUpdate();
                            }
                            else
                            {
                                transform.position += new Vector3(0, 1, 0);
                                DeleteRow();
                                FindObjectOfType<SpawnBox2>().SpawnNewBox();
                                enabled = false;
                            }
                        }
                        else if (Mathf.FloorToInt(touch.deltaPosition.y) < -15)
                        {
                            transform.position += new Vector3(0, Input.touches[0].deltaPosition.y / Mathf.Abs(Input.touches[0].deltaPosition.y ), 0);
                            boolTimerZ = false;
                            if (isValidPosition())
                            {
                                GridUpdate();
                            }
                            else
                            {
                                transform.position += new Vector3(0, 1, 0);
                                DeleteRow();
                                FindObjectOfType<SpawnBox2>().SpawnNewBox();
                                enabled = false;
                            }
                        }
                    }
                    break;
                case TouchPhase.Ended:
                    break;
            } //aşşağı dokunmatik hareket
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    boolTimer = true;
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    if(boolTimer == true)
                    {
                        if (Mathf.FloorToInt(Input.touches[0].deltaPosition.x) > 20 || Mathf.FloorToInt(Input.touches[0].deltaPosition.x) < -20)
                        transform.position += new Vector3(Input.touches[0].deltaPosition.x / Mathf.Abs(Input.touches[0].deltaPosition.x), 0, 0);
                        boolTimer = false;
                        if (isValidPosition())
                            GridUpdate();
                        else
                        {
                            if ((Mathf.FloorToInt(Input.touches[0].deltaPosition.x) > 0)) transform.position += new Vector3(-1, 0, 0);
                            if ((Mathf.FloorToInt(Input.touches[0].deltaPosition.x) < 0)) transform.position += new Vector3(1, 0, 0);
                        }
                    }
                    break;
                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    break;
            } // sağ sol dokunmatik hareket
            
        }

    }
    private void FixedUpdate()
    {
        if(hiz < 0.7)
        {
            hiz = hiz + 0.0001;
        }

        TouchScreenMovement();
    }
    //string tempString;
    //int tempInt = 0;
    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow) || Click.tempRight == 1)
        {
            transform.position += new Vector3(1, 0, 0);

            if (isValidPosition())
                GridUpdate();
            else
                transform.position += new Vector3(-1, 0, 0);
            Click.tempRight = 0;
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Click.tempLeft == 1)
        {
            transform.position += new Vector3(-1, 0, 0);
            if (isValidPosition())
                GridUpdate();
            else
                transform.position += new Vector3(1, 0, 0);
            Click.tempLeft = 0;
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow) || Click.tempRotate == 1)
        {
            transform.Rotate(0, 0, -90);
            if (isValidPosition())
                GridUpdate();
            else
                transform.Rotate(0, 0, 90);
            Click.tempRotate = 0;
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) || Click.tempDown == 1 ||
                 Time.time - fall >= 1 - hiz )
        {
            transform.position += new Vector3(0, -1, 0);
            if (isValidPosition())
            {
                GridUpdate();
            }
            else
            {
                transform.position += new Vector3(0, 1, 0);
                DeleteRow();
                FindObjectOfType<SpawnBox2>().SpawnNewBox();
                enabled = false;
            }

            fall = Time.time;
            Click.tempDown = 0;
        }
    }

    bool isValidPosition() {        
		foreach (Transform child in transform) {
			Vector2 v = round(child.position);
			if (!isInsideGrid(v))
				return false;
			if (grid[(int)v.x, (int)v.y] != null &&
			    grid[(int)v.x, (int)v.y].parent != transform)
				return false;
		}
		return true;
	}

	void GridUpdate() {
		for (int y = 0; y < gridHeight; ++y)
			for (int x = 0; x < gridWeight; ++x)
				if (grid[x, y] != null)
					if (grid[x, y].parent == transform)
						grid[x, y] = null;
		foreach (Transform child in transform) {
			Vector2 v = round(child.position);
			grid[(int)v.x, (int)v.y] = child;
		}        
	}
	public static Vector2 round(Vector2 v) {
		return new Vector2(Mathf.Round(v.x), Mathf.Round(v.y));
	}
	
	public static bool isInsideGrid(Vector2 pos) {
		return ((int)pos.x >= 0 && (int)pos.x < gridWeight && (int)pos.y >= 0);
	}
	
	public static void Delete(int y) {
		for (int x = 0; x < gridWeight; ++x) {
			Destroy(grid[x, y].gameObject);
			grid[x, y] = null;
		}
        Score.score += 1;
	}

	public static bool isFull(int y) {
		for (int x = 0; x < gridWeight; ++x)
			if (grid[x, y] == null)
				return false;
		return true;
	}

	public static void DeleteRow() {
		for (int y = 0; y < gridHeight; ++y) {
			if (isFull(y)) {
				Delete(y);
				RowDownAll(y+1);
				--y;
			}
		}
	}
	
	public static void RowDown(int y) {
		for (int x = 0; x < gridWeight; ++x) {
			if (grid[x, y] != null) {
				grid[x, y-1] = grid[x, y];
				grid[x, y] = null;
				grid[x, y-1].position += new Vector3(0, -1, 0);
			}
		}
	}
	
	public static void RowDownAll(int y) {
		for (int i = y; i < gridHeight; ++i)
			RowDown(i);
	}
}

//private void OnCollisionEnter2D(Collision2D collision)
//{
//    if(collision.gameObject.tag == "karakter")
//    {
//        if (Input.GetKey(KeyCode.D)) //ve karakter cismin sağında ise olayını ekle yoksa solunda iken de D ye basarsa cisim sağa sağa kayar.
//        {
//            Debug.Log("karaktercollision + D");
//            transform.position += new Vector3(1, 0, 0);

//            if (isValidPosition())
//            {
//                GridUpdate();
//            }

//            else
//                transform.position += new Vector3(-1, 0, 0);
//        }

//        if (Input.GetKey(KeyCode.A)) //ve karakter cismin solunda ise olayını ekle yoksa sağında iken de A ye basarsa cisim sağa sağa kayar.
//        {
//            Debug.Log("karaktercollision + A");
//            transform.position += new Vector3(-1, 0, 0);
//            if (isValidPosition())
//                GridUpdate();
//            else
//                transform.position += new Vector3(1, 0, 0);
//        }
//    }
//}
