using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    public AudioClip pickUpClip;

   

    private void OnMouseDown()
    {
        if (!GameControl.huhuu)
        {
            transform.Rotate(0f, 0f, 90f);

            AudioSource.PlayClipAtPoint(pickUpClip, transform.position);

           
        }

        
    }

    
}
