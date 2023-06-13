using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableKey : MonoBehaviour
{
    public GameObject OpenDoor;
    public GameObject ClosedDoor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void DisableDoor()
    {
                if (OpenDoor.activeInHierarchy == true)
        {
            OpenDoor.SetActive(false);
            ClosedDoor.SetActive(true);
        }

    }
        private void OnTriggerEnter(Collider other)
    {
        Invoke("DisableDoor", 0.45f);
    }
}
