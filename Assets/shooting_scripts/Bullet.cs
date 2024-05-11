using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int killScore = 0;
    public GameObject deadEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (killScore == 5)
        { // Eðer öldürme sayýsý tam 3 ise
            print("3 düþman öldürüldü!");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            Destroy(collision.gameObject); // Düþman veya asteroid objesini yok et
            killScore += 1; // Öldürme sayýsýný artýr

           
            Destroy(gameObject); // Mermi objesini de yok et
        }
    }
}
