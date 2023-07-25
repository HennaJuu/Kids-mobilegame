using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JigsawButton : MonoBehaviour
{
    public void LoadScene(string Jigsaw)
    {
        SceneManager.LoadScene(Jigsaw);
    }
}
