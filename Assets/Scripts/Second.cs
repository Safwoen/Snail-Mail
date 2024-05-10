using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Second : MonoBehaviour
{
    public GameObject correctForm;

    private bool moving;

    private float startPosX;
    private float startPosY;
    public AudioSource paper;
    public AudioSource stamp;
    [SerializeField] AudioSource music;
    float musicTime;

    private Vector3 resetPosition;
    void Start()
    {
        music.Play();
        music.time = musicTime;
        resetPosition = this.transform.localPosition;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update()
    {

        if (moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
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

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            moving = true;

            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            paper.PlayOneShot(paper.clip);
            //if this.go.stampValue == letter.stampValue 
        }
    }

    private void OnMouseUp()
    {
        moving = false;
        if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f &&
           Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.5f)

        {
            this.transform.localPosition = new Vector3(correctForm.transform.localPosition.x, correctForm.transform.localPosition.y, correctForm.transform.localPosition.z);
            stamp.PlayOneShot(stamp.clip);
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;

        }
        //this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }


   
}
