using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject bulletPoint;
    float bulletSpeed = 1;
    void Update()
    {
        rb.AddForce( bulletPoint.transform.up * bulletSpeed * Time.deltaTime, ForceMode2D.Impulse);
    }
}
