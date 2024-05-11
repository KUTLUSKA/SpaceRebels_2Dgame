using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
    public void ChangeScene1()
    {
        SceneManager.LoadScene(2);
    }
    public void ChangeSceneUI()
    {
        SceneManager.LoadScene(0);
    }
}