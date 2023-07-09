using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2secretDoor : MonoBehaviour
{
    // Start is called before the first frame update
    private LVL2Pared lvlparedscript;
    public GameObject secretDoorObject;
    public GameObject scriptLevelTwo;
    void Start()
    {
        lvlparedscript = scriptLevelTwo.GetComponent<LVL2Pared>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lvlparedscript.secretDoor == true) {
            secretDoorObject.SetActive(false);
        }
    }
}
