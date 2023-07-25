using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class buttonAudio : MonoBehaviour
{
    void Awake()
    {
        

        DontDestroyOnLoad(this.gameObject);
    }
}