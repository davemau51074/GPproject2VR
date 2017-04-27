using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {

    float num;
	// Use this for initialization
	void Start () {
        num = Random.Range(0.0001f, 0.01f);
    }

	// Update is called once per frame
	void Update () {
        var z = Time.deltaTime * 0.5f;
        transform.Translate(0, 0,  num);

    }
}
