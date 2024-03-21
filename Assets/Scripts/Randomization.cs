using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomization : MonoBehaviour
{

    public List<GameObject> colors, labels;
    List<GameObject> temp_colors, temp_labels;
    public GameObject billDetection;
    public GameObject ActiveColour, ActiveItem;
    char packageType = 'l';
    public bool spawnNew = true;

    // Start is called before the first frame update
    void Start()
    {
        temp_colors = colors; temp_labels = labels;
    }

    void Update()
    {
        if (spawnNew)
        {
            if (temp_colors.Count <= 0)
            {
                temp_colors = colors;
            }
            //randomises stamp color
            foreach (GameObject x in temp_colors)
            {
                x.SetActive(false);
            }
            int rnd = Random.Range(0, temp_colors.Count);
            ActiveColour =temp_colors[rnd];
            ActiveColour.SetActive(true);
            temp_colors.RemoveAt(rnd);


            //randomises label
            if (packageType == 'l')
            {
                ActiveItem = billDetection;
            }
            else
            {
                //do the random things
            }
            
            spawnNew = false;
        }

    }  
    
}
