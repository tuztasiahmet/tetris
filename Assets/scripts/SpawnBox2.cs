using UnityEngine;
using System.Collections;

public class SpawnBox2 : MonoBehaviour {

	public GameObject[] boxList;
    public GameObject[] showBoxList;
    public static int sonrakiBlok;
    private int i;
    public Transform showBoxSpot;
    public static bool kontrol = false;
    public bool kontrol2 = false;

	void Start () {
        i = Random.Range(0, boxList.Length);
        SpawnNewBox();
    }

	public void SpawnNewBox() {
        if(kontrol2 == true)
        {
            kontrol = true;
        }
        sonrakiBlok = i;
        Instantiate(boxList[sonrakiBlok], transform.position, Quaternion.identity);
        sonrakiBlok = Random.Range(0, boxList.Length);
        i = sonrakiBlok;
        Instantiate(showBoxList[sonrakiBlok], showBoxSpot.position, Quaternion.identity);
        kontrol2 = true;
    }
}
