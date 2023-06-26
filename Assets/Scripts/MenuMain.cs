using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour
{
   // void Start()
   // {
   //    Time.timeScale = 1;
   // }
   public void Play()
   {
    SceneManager.LoadScene(1);
   }
   
   public void Exit()
   {
    Debug.Log("Application Exit");
    Application.Quit();
   }
}
