using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroll : MonoBehaviour
{
    [SerializeField] GameObject scrollObject;
    [Range(0,100)]
    [SerializeField] float speed;


    [Header("Loop")]
    [SerializeField] bool loop;
    [SerializeField] float restartPos;
    Vector3 startPos;
    RectTransform scrollRectTransform;

    // Start is called before the first frame update
    void Start()
    {
        scrollRectTransform = scrollObject.GetComponent<RectTransform>();
        startPos = scrollRectTransform.anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        scrollObject.transform.Translate(Vector3.up * speed * Time.deltaTime);

        if(loop)
        {
            float bottomPosY = scrollRectTransform.anchoredPosition.y - scrollRectTransform.sizeDelta.y;
            if(restartPos < bottomPosY)
            {
                scrollRectTransform.anchoredPosition = startPos;
            }
        }
    }
}
