using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public int id;

    public AudioClip dropClip;

    public ParticleSystem star;

    

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {


            if (eventData.pointerDrag.GetComponent<DragAndDrop>().id == id)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                AudioSource.PlayClipAtPoint(dropClip, transform.position);
                Instantiate(star, gameObject.transform.position, Quaternion.identity);

            }

            else
            {
                eventData.pointerDrag.GetComponent<DragAndDrop>().ResetPosition();
            }

            
        }
        
    }
    

}
