using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    public GameObject correctForm;
   
    private bool moving;

    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;

    public List<GameObject> colors, labels;
    List<GameObject> temp_colors, temp_labels;
    public GameObject billDetection;
    char packageType;
    bool spawnNew;
    void Start()
    {
        resetPosition = this.transform.position;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
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
            temp_colors[rnd].SetActive(true);
            temp_colors.RemoveAt(rnd);

            
            //randomises label
            if (packageType == 'l') { 
                billDetection.SetActive(true);
            }
            else
            {
                //do the random things
            }
            spawnNew = false;
        }
        
        
        if (moving) 
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                                                  
            this.gameObject.transform.position = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.position.z);
            //this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }                
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.position.x;
            startPosY = mousePos.y - this.transform.position.y;
            moving = true;
             
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            //if this.go.stampValue == letter.stampValue 
        }
    }

    private void OnMouseUp()
    {
        moving = false; 
        if(Mathf.Abs(this.transform.position.x - correctForm.transform.position.x) <=0.5f &&
           Mathf.Abs(this.transform.position.y - correctForm.transform.position.y) <= 0.5f)
            {
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            }
            else
            {
            this.transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }           
        //this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}
