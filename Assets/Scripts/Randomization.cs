using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomization : MonoBehaviour
{

    public List<GameObject> colors, labels;
    List<GameObject> temp_colors, temp_labels;
    public GameObject billDetection;
    char packageType;
    bool spawnNew;

    // Start is called before the first frame update
    void Start()
    {

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
            temp_colors[rnd].SetActive(true);
            temp_colors.RemoveAt(rnd);


            //randomises label
            if (packageType == 'l')
            {
                billDetection.SetActive(true);
            }
            else
            {
                //do the random things
            }
            spawnNew = false;
        }

    }  
    
}
