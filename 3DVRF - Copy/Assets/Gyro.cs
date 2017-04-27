using UnityEngine;
using System.Collections;
public class Gyro : MonoBehaviour
{

    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        var x = Input.gyro.rotationRateUnbiased.x;
        var y = Input.gyro.rotationRateUnbiased.y;
        var z = Input.gyro.rotationRateUnbiased.z;

        transform.Rotate(-x, -y, z);

    }
}