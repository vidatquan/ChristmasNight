using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class DialogManger : MonoBehaviour
{
    public static DialogManger Instance;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;
    public int count;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue,int check = 0)
    {
        Debug.Log("Start conversation with " + dialogue.name);
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        //test
        /*foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }*/

        //check da duoc tang qua.
       /* if (check == 1)
        {
            dialogueText.text = "MERRY CHRISTMAS !!!";
            return;
        }
        else*/
            DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }    

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);

        dialogueText.text = sentence;


    }

    public void EndDialogue()
    {
        GameObject[] conver = GameObject.FindGameObjectsWithTag("Conversation");
        conver[0].SetActive(false);
        Debug.Log("End of conversation.");
    }
}
