using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pöllö;

    [SerializeField]
    private GameObject win;

    public static bool huhuu;

    public ParticleSystem tähti;

    public GameObject huhuuButton;

    private void Start()
    {
        win.SetActive(false);
        huhuu = false;
        huhuuButton.SetActive(false);
        
    }

   

    private void Update()
    {
        if (pöllö[0].rotation.z == 0 &&
            pöllö[1].rotation.z == 0 &&
            pöllö[2].rotation.z == 0 &&
            pöllö[3].rotation.z == 0 &&
            pöllö[4].rotation.z == 0 &&
            pöllö[5].rotation.z == 0)
        {
            huhuu = true; 
            win.SetActive(true);
            tähti.Play();
            huhuuButton.SetActive(true);
            Destroy(gameObject);

        }
    }

}
