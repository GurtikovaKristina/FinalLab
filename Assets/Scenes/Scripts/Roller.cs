using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
    {
        speed = 60;
        transform.Rotate(Vector3.down * (speed * Time.deltaTime));
    }
}
