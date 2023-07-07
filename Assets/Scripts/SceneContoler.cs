using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneContoler : MonoBehaviour
{
    private float timeEnlapsed;
    private float endTime = 80f;
    private float originalTimeScale;
    //para controlar la gameover scene
    private float activarRip;
    private float activarRipEnd=6f;
    public GameObject brain;
    public GameObject rip;
    
    
    // Start is called before the first frame update
    void Start()
    {
        originalTimeScale = Time.timeScale;
        
    }

    // Update is called once per frame
    void Update()
    {
        cambiarScene();
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(2);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale *= 2f;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Time.timeScale = originalTimeScale;
        }
        endGame();

    }
    public void cambiarScene()
    {
        timeEnlapsed += Time.deltaTime;
        Debug.Log(timeEnlapsed);
        if (timeEnlapsed > endTime)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void endGame()
    {
        activarRip += Time.deltaTime;
        Debug.Log(activarRip);
        if (activarRip > activarRipEnd)
        {
            brain.SetActive(false);
            rip.SetActive(true);
        }
    }
           
    
}

