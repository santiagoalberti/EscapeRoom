using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class PasscodeLvl2 : MonoBehaviour
{
    public GameObject secretwall;
    //objeto para controlar el sonido de dropeo de la llave
    public AudioSource audioSourceParedSecreta;
    //objeto para controlar el sonido de error del panel
    public AudioSource audioSourceErrorKeyPad2;
    public AudioSource AudioSourceSuspenseMusic;

    
    //string Code = "1984";
    string CodeLvl2 = "1984";
    string Nr = null;
    int NrIndex = 0;
    string alpha;
    public TextMeshProUGUI UiTextTwo = null;
    public GameObject keypadCanvasLvl2;
    public Behaviour stopPlayer;



    public void CodeFunctionLvl2(string Numbers)
    {
        NrIndex++;
        Nr = Nr + Numbers;
        UiTextTwo.text = Nr;
        if (Nr.Length == 4)
        {
            EnterLvl2();
            DeleteLvl2();
        }

    }
    public void EnterLvl2()
    {
            if   (Nr == CodeLvl2) {
            Debug.Log("codigo correcto");
            secretwall.SetActive(false);
            Debug.Log("pared secreta abierta");
            
            audioSourceParedSecreta.Play();
            Debug.Log("sonido pared secreta");
            AudioSourceSuspenseMusic.Play();
        }
        else
        {
            Debug.Log(" error en codigo");
            audioSourceErrorKeyPad2.Play();
            Debug.Log("sonido de error");
        }
        // if (Nr == Code)
        // {
        //     SceneManager.LoadScene(1);
        // }
    }
    public void DeleteLvl2()
    {
        NrIndex++;
        Nr = null;
        UiTextTwo.text = Nr;  
    }

    public void ExitKeypadLvl2()
    {
        keypadCanvasLvl2.SetActive(false);
        stopPlayer.enabled = true;
    }
}