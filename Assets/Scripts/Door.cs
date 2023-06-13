using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator anim;
    private bool canOpen = false;
    private bool isClosed = true;
    public Key scriptLlave;
    public bool tengoLlave;
    void Start()
    {
        anim = GetComponent<Animator>();
        scriptLlave = FindObjectOfType<Key>(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        tengoLlave = scriptLlave.laTengo;
        if (canOpen == true && Input.GetKey(KeyCode.E) && tengoLlave == true)
        {
            anim.SetTrigger("OpenDoor");
            canOpen = false;
            isClosed = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canOpen = true;
        
            //anim.SetTrigger("CloseDoor");
        }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
        canOpen = false;
        }
        if (isClosed == false)
        {
        anim.SetTrigger("CloseDoor");
        isClosed = true;
        
        }
        
        

        
        // if (isClosed == false)
        // {
        // anim.SetTrigger("CloseDoor");
        // isClosed = true;
        // canOpen = false;
        // }
        
        
        //anim.SetBool("CloseDoorBool", true);
        
    }
}
