using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogueBox; // Diyalog kutusunun UI Panel'ini buraya sürükleyip býrakýn

    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Eðer çarpýþan obje "Player" tag'ine sahipse
        {
            dialogueBox.SetActive(true); // Diyalog kutusunu göster
            print("collide");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Eðer player çarpýþma alanýndan çýkarsa
        {
            dialogueBox.SetActive(false); // Diyalog kutusunu gizle
        }
    }
 
}