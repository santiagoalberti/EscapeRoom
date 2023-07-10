using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public GameObject linterna;
    public GameObject linternaenmano;
    public bool laTengo;
       public GameObject linternaInteractCanvas;
    float raycastDistance = 2; //Adjust to suit your use case

    // Start is called before the first frame update
    void Start()
    {
        laTengo = false;
        linternaenmano.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        LinternaCanvas();
    }

    // private void OnMouseDown()
    // {
    //     laTengo = true;
    //     linterna.SetActive(false);
    //     linternaenmano.SetActive(true); 
    //     Debug.Log("tengo la linterna");
    // }
    private void LinternaCanvas()
    {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // This creates a 'ray' at the Main Camera's Centre Point essentially the centre of the users Screen

        RaycastHit hit; //This creates a Hit which is used to callback the object that was hit by the Raycast

        if (Physics.Raycast(ray, out hit, raycastDistance)) //Actively creates a ray using the above set perameters at the predeterminded distance
        {
            //Item Raycast Detection
            if (hit.collider.CompareTag("Linterna"))//Checking if the Raycast has hit a collider with the tag of note
            {
                
                linternaInteractCanvas.SetActive(true);
                //interactText.text = "Press [E] to enter the code."; //Setting the Interaction Text to let the player know they are now hovering an interactable object
                       if (Input.GetKeyDown("e"))
        {
                    laTengo = true;
        linterna.SetActive(false);
             linternaenmano.SetActive(true); 
             Debug.Log("tengo la linterna");
        
        linternaInteractCanvas.SetActive(false);
        }


            }
                            else if (!hit.collider.CompareTag("Linterna"))
                {
                    linternaInteractCanvas.SetActive(false);
                }
            //else if (hit.collider.CompareTag("NEW_OBJECT_TAG_HERE"))
            //{
                //Add a different object here if you choose to want more objects to be able to be detected by the Raycast such as doors etc
            //}

            //else //If nothing at all with an above tag was hit with the Raycast within the specified distance then run this
            //{
                // if(interactText.text != "")//If the interactText is not already set as nothing then set it to nothing - this is to help optimise and save from constantly spamming this request
                // {
                //     interactText.text = ""; //Removing the text as nothing was detected by the raycast
                // }
            //}
        }
    }
}
