using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LVL1Cartas : MonoBehaviour
{
    //variable almacena los datos ingresados por el usuario

    private string input;
    //variable con la respuesta correcta,el tanto de las cartas.
    private string respuesta = "3332";
    //obejto para controlar la llave (activa o desactiva la llave en escena)
    public GameObject showkey;
    //objeto para controlar el sonido de dropeo de la llave
    public AudioSource audioSourceDropKey;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //ver que implementamos si es correcto el codigo y que pasa si esta mal
    public void readInputCode(string s)
    {
        input = s;
        Debug.Log(input);
        if (s == respuesta)
        {
            Debug.Log("codigo correcto");
            showkey.SetActive(true);
            Debug.Log("llave en escena");
            
            audioSourceDropKey.Play();
            Debug.Log("sonido llave");
        }
        else
        {
            Debug.Log(" error en codigo");
        }
    }
}
