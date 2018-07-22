using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningScript : MonoBehaviour {

    private int offset = 192;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("MyCar").transform.position.z >= transform.position.z + 48f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, offset + transform.position.z);
            
        }
    }
}
