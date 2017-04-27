
        using UnityEngine;
        using System.Collections;

public class movingCamera : MonoBehaviour
{
    private Quaternion localRotation; // 
    public float speed = 100000.0f; // ajustable speed from Inspector in Unity editor

    // Use this for initialization
    void Start()
    {
        // copy the rotation of the object itself into a buffer
    localRotation = transform.rotation;
    }


    void Update() // runs 60 fps or so
    {
        // find speed based on delta
        float curSpeed = Time.deltaTime * speed;
        // first update the current rotation angles with input from acceleration axis
        localRotation.y -= Input.acceleration.x * curSpeed;

     //   if(localRotation.y > 500)
        localRotation.x += Input.acceleration.y * curSpeed;

        // then rotate this object accordingly to the new angle
        transform.rotation = localRotation;

    }
}


