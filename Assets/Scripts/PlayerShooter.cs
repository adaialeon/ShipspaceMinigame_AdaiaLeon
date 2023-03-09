using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour 
{

    public GameObject bulletPrefab;
    public float bulletSpeed = 10.0f;
    int disparo = 0;
    public Transform gunPosition;

    void Update () 
    {
        if (Input.GetKeyDown (KeyCode.Space)) 
        {
            /*GameObject bullet = Instantiate (bulletPrefab, transform.position, Quaternion.identity) as GameObject;
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody> ();
            bulletRigidbody.velocity = new Vector3 (0.0f, 0.0f, bulletSpeed);*/

            GameObject bullet = PoolManager.Instance.GetPooledObjects(disparo, gunPosition.position, gunPosition.rotation);
            bullet.SetActive(true);
        }
    }
}
 