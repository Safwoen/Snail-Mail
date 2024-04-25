using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpIndicators : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {

            bool isActive = Canvas.activeSelf;

            Canvas.SetActive(!isActive);
        }
    }

}
