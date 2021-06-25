using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;
using TMPro;

public class MenuHandler : MonoBehaviour
{
    private string input;
    public TextMeshProUGUI highScoreText;

    private void Start()
    {
        highScoreText.text = "Best Score: " + DataManager.Instance.recordHolder + ": " + DataManager.Instance.highScore;
    }

    public void GetNameEntry(string username)
    {
        input = username;
        DataManager.Instance.currentUser = input;
        Debug.Log("username is " + DataManager.Instance.currentUser);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }
}
