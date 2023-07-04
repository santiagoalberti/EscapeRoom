using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class estresControl : MonoBehaviour
{
    //variables para almacenar el estres
    float energiaMaxima = 100f;
    float energiaActual;
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
    }
    public void reducirEnergia()
    {
        energiaActual -= 5*Time.deltaTime;
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
}
