using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject llave;
    public bool laTengo;
    public AudioSource sonido;
    public GameObject keyInteractCanvas;
    float raycastDistance = 3; //Adjust to suit your use case

    // Start is called before the first frame update
    void Start()
    {
        laTengo = false;
    }

    // Update is called once per frame
    void Update()
    {
        KeyCanvas();
    }

    // private void OnMouseDown()
    // {
    //     laTengo = true;
    //     sonido.Play();
    //     Debug.Log("tengo la llave");
    //     llave.SetActive(false);
    //     keyInteractCanvas.SetActive(false);
    // }



    private void KeyCanvas()
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
                       if (Input.GetKeyDown("e"))
        {
                    laTengo = true;
        sonido.Play();
        Debug.Log("tengo la llave");
        llave.SetActive(false);
        keyInteractCanvas.SetActive(false);
        }


            }
                            else if (!hit.collider.CompareTag("Key"))
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
