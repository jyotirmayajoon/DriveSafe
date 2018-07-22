using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftGasStationScript2 : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
            transform.position = new Vector3(-transform.position.x - 644f, transform.position.y, transform.position.z - 144f+20f);
            transform.rotation = Quaternion.Euler(0, -180, 0);
    }
	
	
}
