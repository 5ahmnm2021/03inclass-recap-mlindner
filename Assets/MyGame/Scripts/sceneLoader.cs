using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Scene Loader Marco Lindner

public class sceneLoader : MonoBehaviour
{
    public void LoadColorScene()
    {
        SceneManager.LoadScene("01colorScene");
    }

    public void LoadNumberScene()
    {
        SceneManager.LoadScene("02numberScene");
    }

    public void LoadWelcomeScene()
    {
        SceneManager.LoadScene("00welcomeScene");
    }
}
