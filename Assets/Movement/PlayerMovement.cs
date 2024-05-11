using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 200.0f;
    public int health = 3;  

    public GameObject fullHealthImage;   
    public GameObject damagedHealthImage;  
    public GameObject lowHealthImage;  
    

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        if (movement != Vector2.zero)
        {
            float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg - 90f;
            Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Asteroid"))
        {
            TakeDamage();
        }
    }

    void TakeDamage()
    {
        health -= 1;
        Debug.Log("Current Health: " + health); // Saðlýk durumunu kontrol et
        UpdateHealthUI();
        if (health <= 0)
        {
            Debug.Log("Game Over Triggered"); // Oyun bitiþini logla
            RestartGame();
        }
    }

    void UpdateHealthUI()
    {
        // Saðlýk durumunu görsel olarak güncelle
        fullHealthImage.SetActive(health == 3);
        damagedHealthImage.SetActive(health == 2);
        lowHealthImage.SetActive(health == 1);

        Debug.Log("Health UI Updated"); // UI güncelleme durumunu logla
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
