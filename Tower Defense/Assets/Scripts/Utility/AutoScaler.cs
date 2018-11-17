using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScaler : MonoBehaviour {

    // Use this for initialization
    public float scaleSpeed;
	
	// Update is called once per frame
	void Update ()
    {
        transform.localScale += (new Vector3(scaleSpeed, scaleSpeed, scaleSpeed) * Time.deltaTime);
	}
}
