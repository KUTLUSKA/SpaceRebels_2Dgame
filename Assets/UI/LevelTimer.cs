using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelTimer : MonoBehaviour
{
    public float levelTime = 1.0f; // 2 dakika i�in s�re, saniye olarak


    public TextMeshProUGUI timerText; // TextMesh Pro UI elementi i�in referans

    void Start()
    {
        // E�er Text objesi atanmam��sa, hata mesaj� ver
        if (timerText == null)
        {
            Debug.LogError("TimerText is not assigned! Please assign it in the inspector.");
            this.enabled = false; // Script'i devre d��� b�rak
            return;
        }

        UpdateTimerText(levelTime); // Ba�lang�� s�resini ekrana yazd�r
    }

    void UpdateTimerText(float timeToDisplay)
    {
        // S�reyi dakika:saniye format�nda g�ster
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void Update()
    {
        // Her karede s�reyi azalt
        levelTime -= Time.deltaTime;

        // UI'da s�reyi g�ncelle
        UpdateTimerText(levelTime);

        // S�re bitti�inde ne yap�laca��
        if (levelTime <= 0)
        {
            NextLevel();
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(0);
        
    }
}
