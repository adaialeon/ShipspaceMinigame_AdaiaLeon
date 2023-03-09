using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    public float speed = 10.0f;

    void Update () 
    {
        float horizontal = Input.GetAxis ("Horizontal");
        Vector3 newPosition = transform.position + new Vector3 (horizontal * speed * Time.deltaTime, 0.0f, 0.0f);
        transform.position = newPosition;
    }
}