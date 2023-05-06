using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorLogic : MonoBehaviour
{
    public float speed;
    private float offset;
    private Material material;
    Rigidbody rBody;
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        material = GetComponent<Renderer>().material;
    }


    void FixedUpdate()
    {
        Vector3 pos = rBody.position;
        rBody.position += Vector3.back * speed * Time.fixedDeltaTime;
        rBody.MovePosition(pos);
        offset += speed * Time.fixedDeltaTime;
        material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        
    }
}
