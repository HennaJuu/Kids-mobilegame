using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragDropButton : MonoBehaviour
{
    public void LoadScene(string DragAndDrop)
    {
        SceneManager.LoadScene(DragAndDrop);
    }
}
