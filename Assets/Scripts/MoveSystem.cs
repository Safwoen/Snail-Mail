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

    bool colliding;
    Collider2D other;
    void Start()
    {
        resetPosition = this.transform.position;
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            OnMouseUp();
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
        if (colliding)
        {
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            if (other.CompareTag(transform.tag))
            {
                FindObjectOfType<Randomization>().ActiveItem.SetActive(true);
            }
            else if (other.CompareTag(transform.tag))
            {
                FindObjectOfType<Randomization>().spawnNew = true;
            }
        }
        else
        {
            this.transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ASGGHKHG");
        colliding = true;
        other = collision;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        colliding = false;
        other = null;
    }
}
