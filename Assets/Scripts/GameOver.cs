using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    //para controlar la gameover scene
    private float activarRip;
    private float activarRipEnd = 6f;
    public GameObject brain;
    public GameObject rip;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   

    // Update is called once per frame
    void Update()
    {
        endGame();
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
    public void backToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
