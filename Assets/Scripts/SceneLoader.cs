using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    static string MAIN_SCENE_NAME = "MainScene";

    public static void LoadMainScene()
    {
        SceneManager.LoadScene(MAIN_SCENE_NAME);
    }

    public static void ExitGame()
    {
        Application.Quit();
    }
}
