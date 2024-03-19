using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueManager dm;
    public GameObject box;

    private void Start()
    {
        dm = FindObjectOfType<DialogueManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("asdfsdfsd");
        if (other.CompareTag("Player"))
        {
            box.SetActive(true);
            dm.StartDialogue(dialogue);
            //other.GetComponent<CharacterController>().collectablesCollected++;
            //Destroy(gameObject);
        }
    }

}
