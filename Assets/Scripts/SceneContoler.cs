using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneContoler : MonoBehaviour
{
    private float timeEnlapsed;
    private float endTime=75f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cambiarScene();
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

