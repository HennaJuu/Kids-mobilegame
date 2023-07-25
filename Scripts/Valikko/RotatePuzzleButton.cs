using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotatePuzzleButton : MonoBehaviour
{
    public void LoadScene(string RotatingPuzzle)
    {
        SceneManager.LoadScene(RotatingPuzzle);
    }
}
