using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public GameObject interactCanvas;
    public GameObject interactCanvasZoom;
    public float interactionDistance = 2f;

    private bool canInteract = false;

    private void Update()
    {
        // Check if the player is within interaction distance and looking at the object
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            interactCanvas.SetActive(false);
            interactCanvasZoom.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player enters the interaction zone
        if (other.CompareTag("Player"))
        {
            canInteract = true;
            interactCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the player exits the interaction zone
        if (other.CompareTag("Player"))
        {
            canInteract = false;
            interactCanvas.SetActive(false);
            interactCanvasZoom.SetActive(false);
        }
    }

    private void Interact()
    {
        // Perform the interaction logic here
        Debug.Log("Interacting with the object!");
    }
}