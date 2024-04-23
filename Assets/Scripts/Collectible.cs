using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueManager dm;
    public GameObject box;
    public GameObject Image;

    GameObject test;
    bool test2;

    private void Start()
    {
        dm = FindObjectOfType<DialogueManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        test = other.gameObject;
        test2 = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && test2)
        {
            Debug.Log("asdfsdfsd");
            if (test.CompareTag("Player"))
            {
                box.SetActive(true);
                dm.StartDialogue(dialogue);
                //test.GetComponent<CharacterController>().collectablesCollected++;
                //Destroy(gameObject);
            }
        }

        void OnTriggerEnter(Collider2D other)
        {
          if (other.gameObject.tag == "Player")
            {
                Image.SetActive(true);
            }
            
        
        }

       void OnCollisionEnter2D (Collision other)
        {
            Image.SetActive(true); 
            
        }
    }

}
