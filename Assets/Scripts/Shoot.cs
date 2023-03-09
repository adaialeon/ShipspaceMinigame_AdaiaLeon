using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.forward * 5 * Time.deltaTime;
    }
    
    void OnCollisionEnter (Collision enemy)
    {
        this.gameObject.SetActive(false);
    }
}
