using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5.0f; 
    private Transform playerTransform; 

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (playerTransform != null)
        {
            MoveTowardsPlayer();
            RotateTowardsPlayer();
        }
    }

    // Oyuncuya do�ru hareket
    void MoveTowardsPlayer()
    {
        Vector3 direction = (playerTransform.position - transform.position).normalized; // Hareket y�n�n� hesaplama
        transform.position += direction * speed * Time.deltaTime; // Hareket
    }

    // Oyuncuya do�ru rotasyon
    void RotateTowardsPlayer()
    {
        Vector3 direction = playerTransform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90; // Rotasyon a��s�n� bulma
        transform.rotation = Quaternion.Euler(0, 0, angle); // Z ekseni etraf�nda d�nme
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
