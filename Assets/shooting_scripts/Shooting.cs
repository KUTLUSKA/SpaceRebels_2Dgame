using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform bulletPoint; 
    public GameObject bulletPrefab; 
    public float bulletForce = 20f;

    void Update()
    {
        // Eðer boþluk tuþuna basýlýrsa
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(); // Ateþ etme fonksiyonunu çaðýr
        }
    }

    void Shoot()
    {
        // Mermi prefabýný firePoint pozisyonunda ve rotasyonunda oluþtur
        GameObject bullet = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = transform.up * 10;
        }
        else
        {
            print("Rigidbody Bulunamadý...");
        }

    }
}
