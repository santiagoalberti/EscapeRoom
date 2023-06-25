using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVL1Cartas : MonoBehaviour
{
    //variable almacena los datos ingresados por el usuario
    
    private string input;
    private string respuesta = "3332";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //ver aun no funciona bien
    public void readInputCode(string s) {
        input = s;
        Debug.Log(input);
        if (s == respuesta) {
            Debug.Log("codigo correcto");
        }
        else
        {
            Debug.Log(" error en codigo");
        }
    }
}
