using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    float spin;

    // Use this for initialization
    void Start () {
        spin = gameObject.GetComponent<RectTransform>().rotation.z;
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, spin + 10));
    }
}
