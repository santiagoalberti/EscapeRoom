using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LVL2Pared : MonoBehaviour
{
    //variable almacena los datos ingresados por el usuario

    private string input;
    //variable con la respuesta correcta,el tanto de las cartas.
    private string respuesta = "1234";
    public bool secretDoor = false;
    //obejto para controlar la llave (activa o desactiva la llave en escena)
    //public GameObject showkey;
    //objeto para controlar el sonido de dropeo de la llave
    //public AudioSource audioSourceDropKey;
    
    
    public AudioSource audioSourceSecretWall;
    //objeto para controlar el sonido de error del panel
    public AudioSource audioSourceErrorKeyPad;

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
            //showkey.SetActive(true);
            Debug.Log("puerta secreta abierta");
            secretDoor = true;
            audioSourceSecretWall.Play();
            Debug.Log("sonido pared");
        }
        else
        {
            Debug.Log(" error en codigo");
            audioSourceErrorKeyPad.Play();
            Debug.Log("sonido de error");
        }
    }
}
