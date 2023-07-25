using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColoringButton : MonoBehaviour
{
    public void LoadScene(string ColoringGame)
    {
        SceneManager.LoadScene(ColoringGame);
    }
}

