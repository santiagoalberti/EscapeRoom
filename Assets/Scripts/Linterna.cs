using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public GameObject linterna;
    public GameObject linternaenmano;
    public bool laTengo;

    // Start is called before the first frame update
    void Start()
    {
        laTengo = false;
        linternaenmano.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        laTengo = true;
        linterna.SetActive(false);
        linternaenmano.SetActive(true); 
        Debug.Log("tengo la linterna");
    }
}
