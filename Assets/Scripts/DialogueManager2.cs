using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Search.Providers;

public class DialogueManager2 : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public GameObject dialogueBox;
    public Sprite[] images;
    public Image portrait;
    public GameObject Score;
    

    public Animator animator;

    private Queue<string> sentences;
    List<string> sentencesList;
    public int currentSentence;
    void Start()
    {

        sentences = new Queue<string>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentSentence++;
            DisplayNextSentence();

        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        {
            currentSentence = 0;
            animator.SetBool("IsOpen", true);
            nameText.text = dialogue.name;
            sentences.Clear();

            foreach (string sentence in dialogue.sentences)
            {
                sentences.Enqueue(sentence);
            }


            DisplayNextSentence();
        }


    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
            

        }


        string sentence = sentences.Dequeue();
        if (sentence.Contains("SPRITE-"))
        {
            switch (sentence.Split('-')[1])
            {
                case "Player":
                    portrait.sprite = images[0];
                    nameText.text = "Dimi";
                    break;
                case "Damien":
                    portrait.sprite = images[1];
                    nameText.text = "Damien";
                    break;
                case "Marigold":
                    portrait.sprite = images[2];
                    nameText.text = "Marigold";
                    break;
                case "Jiji":
                    portrait.sprite = images[3];
                    nameText.text = "Jiji";
                    break;
                case "Keith":
                    portrait.sprite = images[4];
                    nameText.text = "Keith";
                    break;
                case "Katie":
                    portrait.sprite = images[5];
                    nameText.text = "Katie";
                    Score.gameObject.SetActive(true);
                    break;
                
            }
            sentence = sentences.Dequeue();
        }
        else if (sentence.Contains("SHOW SCORE"))
        {
            Score.gameObject.SetActive(true);
            sentence = sentences.Dequeue();
        }
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        
       

    }
}

