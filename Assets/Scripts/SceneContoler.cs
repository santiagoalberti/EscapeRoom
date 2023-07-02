using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneContoler : MonoBehaviour
{
    private float timeEnlapsed;
    private float endTime=80f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cambiarScene();
           if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(2);
        }
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
}

