using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class estresControl : MonoBehaviour
{
    //variables para almacenar el estres
    private float energiaMaxima = 100f;
    private float energiaActual;
    

    //variable para controlar la barra
    public UnityEngine.UI.Image barraVerde;
    //variable para guardar el estallido del cerebro
    public GameObject estallido;
   
    // Start is called before the first frame update
    void Start()
    {
        energiaActual = energiaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        reducirEnergia();
        dead();
    }
    public void reducirEnergia()
    {
        energiaActual -= 1*Time.deltaTime;
        Debug.Log("tengo" + energiaActual + "de" + energiaMaxima);
        barraVerde.fillAmount = energiaActual / energiaMaxima;
        if (energiaActual <= 50f)
        {
            estallido.SetActive(true);
        }
        if (energiaActual <= 25f)
        {
            estallido.GetComponent<Image>().color=Color.cyan;
        }
        

    }
    public void dead()
    {
        if (energiaActual <= 0f)
        {
            
            SceneManager.LoadScene(3);
        }
    }

}
