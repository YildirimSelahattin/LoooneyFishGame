using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodMove : MonoBehaviour
{

    public float speed;

    void Start()
    {
        Destroy(gameObject, 5);
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
