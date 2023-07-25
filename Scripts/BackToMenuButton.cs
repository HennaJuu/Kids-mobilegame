using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenuButton : MonoBehaviour
{
    public void LoadScene(string valikko)
    {
        SceneManager.LoadScene(valikko);
    }
}
