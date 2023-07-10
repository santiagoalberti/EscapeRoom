using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyInteract : MonoBehaviour

{
    
    float raycastDistance = 1; //Adjust to suit your use case

    //public Text interactText; //Create GUI Canvas on your scene if you havnt already and a UI Text Element in a suitable location on your screen and apply it to this Text variable
    public GameObject keyObject;
    public GameObject keyInteractCanvas;
	void Update()
    {        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // This creates a 'ray' at the Main Camera's Centre Point essentially the centre of the users Screen

        RaycastHit hit; //This creates a Hit which is used to callback the object that was hit by the Raycast

        if (Physics.Raycast(ray, out hit, raycastDistance)) //Actively creates a ray using the above set perameters at the predeterminded distance
        {
            //Item Raycast Detection
            if (hit.collider.CompareTag("Key"))//Checking if the Raycast has hit a collider with the tag of note
            {
                
                keyInteractCanvas.SetActive(true);
                //interactText.text = "Press [E] to enter the code."; //Setting the Interaction Text to let the player know they are now hovering an interactable object
                


            }
                            else if (!hit.collider.CompareTag("Keypad"))
                {
                    keyInteractCanvas.SetActive(false);
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