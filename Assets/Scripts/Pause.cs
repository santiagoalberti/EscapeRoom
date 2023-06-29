using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool activePause = false;
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
    
    void TogglePause()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(activePause == true)
            {
                resumeGame();
            }else
            {
                pauseGame();
            }
            
        }
    }

    public void resumeGame()
    {
        pauseMenu.SetActive(false);
        activePause = false;
        Time.timeScale = 1;
    }

    void pauseGame()
    {
        pauseMenu.SetActive(true);
        activePause = true;
        Time.timeScale = 0;
    }

    public void mainmenu()
    {
    pauseMenu.SetActive(false);
    activePause = false;
        
    SceneManager.LoadScene(0);
    Time.timeScale = 1;
    }
}
