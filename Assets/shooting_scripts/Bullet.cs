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
        { // E�er �ld�rme say�s� tam 3 ise
            print("3 d��man �ld�r�ld�!");
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
            
            Destroy(collision.gameObject); // D��man veya asteroid objesini yok et
            killScore += 1; // �ld�rme say�s�n� art�r

           
            Destroy(gameObject); // Mermi objesini de yok et
        }
    }
}
