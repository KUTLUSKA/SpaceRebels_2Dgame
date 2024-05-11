using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstreoidMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector3 moveDirection;

    void Start()
    {
        // Rastgele bir yönde hareket etmesi için açý belirler
        float angle = Random.Range(0, 360) * Mathf.Deg2Rad;
        moveDirection = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0);
    }

    void Update()
    {
        transform.position += moveDirection * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
}
