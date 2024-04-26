using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public int scoreValue = 0;
    public GameObject high ;
    TMP_Text score;
    // Start is called before the first frame update
   void Start()
   {
        score = GetComponent<TMP_Text>();
   }

     //Update is called once per frame
    void Update()
   {
      score.text = " " + scoreValue;
        if (scoreValue <= 2000)
        {
            high. SetActive (true);
        }
       else
        {
            if (scoreValue >= 2000)
            {
                high.SetActive(false);
                //high.enabled = false;
            }
       }
    }
}
