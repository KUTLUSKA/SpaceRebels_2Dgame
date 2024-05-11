using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogueBox; // Diyalog kutusunun UI Panel'ini buraya s�r�kleyip b�rak�n

    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // E�er �arp��an obje "Player" tag'ine sahipse
        {
            dialogueBox.SetActive(true); // Diyalog kutusunu g�ster
            print("collide");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // E�er player �arp��ma alan�ndan ��karsa
        {
            dialogueBox.SetActive(false); // Diyalog kutusunu gizle
        }
    }
 
}