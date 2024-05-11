using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelTimer : MonoBehaviour
{
    public float levelTime = 1.0f; // 2 dakika için süre, saniye olarak


    public TextMeshProUGUI timerText; // TextMesh Pro UI elementi için referans

    void Start()
    {
        // Eðer Text objesi atanmamýþsa, hata mesajý ver
        if (timerText == null)
        {
            Debug.LogError("TimerText is not assigned! Please assign it in the inspector.");
            this.enabled = false; // Script'i devre dýþý býrak
            return;
        }

        UpdateTimerText(levelTime); // Baþlangýç süresini ekrana yazdýr
    }

    void UpdateTimerText(float timeToDisplay)
    {
        // Süreyi dakika:saniye formatýnda göster
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void Update()
    {
        // Her karede süreyi azalt
        levelTime -= Time.deltaTime;

        // UI'da süreyi güncelle
        UpdateTimerText(levelTime);

        // Süre bittiðinde ne yapýlacaðý
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
