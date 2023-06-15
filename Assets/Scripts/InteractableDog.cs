using UnityEngine;

public class InteractableDog : MonoBehaviour
{
    public GameObject interactCanvas;
    public GameObject interactCanvasZoom;
    public float interactDistance = 0.8f;

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, Camera.main.transform.position);

        if (distance <= interactDistance)
        {
            interactCanvas.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                interactCanvas.SetActive(false);
                interactCanvasZoom.SetActive(true);
            }
        }
        else
        {
            interactCanvas.SetActive(false);
            interactCanvasZoom.SetActive(false);
        }
    }

     //private void Interact()
     //{
        // Perform the interaction here
        // Debug.Log("Interacting with the object!");
     //}
}