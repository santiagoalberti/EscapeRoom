using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{
    public AudioSource evilLaugh;
    public AudioSource brathOfDeath;
    public GameObject doorClosedForever;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            evilLaugh.Play();
            brathOfDeath.Play();
            doorClosedForever.SetActive(true);
        
            //anim.SetTrigger("CloseDoor");
        }

    }
}

