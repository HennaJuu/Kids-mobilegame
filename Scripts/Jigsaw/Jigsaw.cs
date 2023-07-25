using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Jigsaw : MonoBehaviour
{
    public GameObject SelectedPiece;

   
    public AudioClip pickUpClip;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (EventSystem.current.IsPointerOverGameObject())
                    return;

                if (!hit.transform.GetComponent<JigsawPieces>().InRightPosition)
                {
                    AudioSource.PlayClipAtPoint(pickUpClip, transform.position);
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<JigsawPieces>().Selected = true;

                }


            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<JigsawPieces>().Selected = false;
                SelectedPiece = null;
            }

        }

        if (SelectedPiece != null)
        {

            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);

        }


    }
}