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
        // E�er bo�luk tu�una bas�l�rsa
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(); // Ate� etme fonksiyonunu �a��r
        }
    }

    void Shoot()
    {
        // Mermi prefab�n� firePoint pozisyonunda ve rotasyonunda olu�tur
        GameObject bullet = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = transform.up * 10;
        }
        else
        {
            print("Rigidbody Bulunamad�...");
        }

    }
}
