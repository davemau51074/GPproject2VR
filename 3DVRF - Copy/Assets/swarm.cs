using UnityEngine;
using System.Collections;

public class swarm : MonoBehaviour {

	// Use this for initialization
	void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
        var z =  Time.deltaTime * 0.5f;
        transform.Translate(0, 0, z);
    }
}
