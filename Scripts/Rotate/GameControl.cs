using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] p�ll�;

    [SerializeField]
    private GameObject win;

    public static bool huhuu;

    public ParticleSystem t�hti;

    public GameObject huhuuButton;

    private void Start()
    {
        win.SetActive(false);
        huhuu = false;
        huhuuButton.SetActive(false);
        
    }

   

    private void Update()
    {
        if (p�ll�[0].rotation.z == 0 &&
            p�ll�[1].rotation.z == 0 &&
            p�ll�[2].rotation.z == 0 &&
            p�ll�[3].rotation.z == 0 &&
            p�ll�[4].rotation.z == 0 &&
            p�ll�[5].rotation.z == 0)
        {
            huhuu = true; 
            win.SetActive(true);
            t�hti.Play();
            huhuuButton.SetActive(true);
            Destroy(gameObject);

        }
    }

}
