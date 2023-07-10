using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Passcode : MonoBehaviour
{
    public GameObject showkey;
    //objeto para controlar el sonido de dropeo de la llave
    public AudioSource audioSourceDropKey;
    //objeto para controlar el sonido de error del panel
    public AudioSource audioSourceErrorKeyPad;
    
    //string Code = "3332";
    string Code = "3332";
    string Nr = null;
    int NrIndex = 0;
    string alpha;
    public TextMeshProUGUI UiText = null;
    public GameObject keypadCanvas;
    public Behaviour stopPlayer;



    public void CodeFunction(string Numbers)
    {
        NrIndex++;
        Nr = Nr + Numbers;
        UiText.text = Nr;
        if (Nr.Length == 4)
        {
            Enter();
            Delete();
        }

    }
    public void Enter()
    {
            if   (Nr == Code) {
            Debug.Log("codigo correcto");
            showkey.SetActive(true);
            Debug.Log("llave en escena");
            
            audioSourceDropKey.Play();
            Debug.Log("sonido llave");
        }
        else
        {
            Debug.Log(" error en codigo");
            audioSourceErrorKeyPad.Play();
            Debug.Log("sonido de error");
        }
        // if (Nr == Code)
        // {
        //     SceneManager.LoadScene(1);
        // }
    }
    public void Delete()
    {
        NrIndex++;
        Nr = null;
        UiText.text = Nr;  
    }

    public void ExitKeypad()
    {
        keypadCanvas.SetActive(false);
        stopPlayer.enabled = true;
    }
}