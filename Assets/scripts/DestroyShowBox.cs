using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShowBox : MonoBehaviour {
    
    private void Update()
    {
        if(SpawnBox2.kontrol == true)
        {
            Destroy(this.gameObject);
            SpawnBox2.kontrol = false;
        }
    }
}
