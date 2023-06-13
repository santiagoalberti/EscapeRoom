using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject llave;
    public bool laTengo;
    public AudioSource sonido;

    // Start is called before the first frame update
    void Start()
    {
        laTengo = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        laTengo = true;
        sonido.Play();
        Debug.Log("tengo la llave");
        llave.SetActive(false);
    }
}
