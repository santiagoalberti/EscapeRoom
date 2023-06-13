using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour
{
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
