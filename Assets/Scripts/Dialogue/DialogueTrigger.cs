using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class DialogueTrigger : MonoBehaviour
{
    public static DialogueTrigger Instance;
    public Dialogue dialogue;
    public GameObject conver;
    public int check1 = 0, check2 = 0, check3 = 0, check4 = 0;
    private bool check = false;
    //private string name;

    public List<string> textForSad;
    public List<string> textForThanks;
    public List<string> textForWish;
    private void Awake()
    {
        Instance = this;
    }


    public void TriggerDialogue()
    {
        FindObjectOfType<DialogManger>().StartDialogue(dialogue);
    }
    private void OnCollisionEnter(Collision other)
    {
        SetText();
        Instance = this;
        if (other.gameObject.CompareTag("Player"))
        {
            //name = this.tag;
            conver.SetActive(true);

            var text = Instance.name;
            var countItem = InventoryManager.Instance.countItem;
            Button continueButton = GameObject.Find("ContinueButton").GetComponent<Button>();
            Button givePresentButton = GameObject.Find("GivePresentButton").GetComponent<Button>();
            TextMeshProUGUI ctnText = GameObject.Find("ContinueText").GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI gpText = GameObject.Find("GivePresentText").GetComponent<TextMeshProUGUI>();

            var count = GameObject.FindGameObjectWithTag("count").GetComponent<TextMeshProUGUI>().text;
            //Debug.Log("test: " + InventoryManager.Instance.countItem);
            /* 
             - ?� c� qu�: g?p ch? hi?n th�ng b�o
             - ch?a c� qu�:
                th1: sl = 0 : ch? hi?n th�ng b�o
                th2: sl 1= 0 : hi?n th�ng b�o + n�t t?ng qu�. t?ng qu� xong th� hi?n th�ng b�o + ?n n�t.
             */
            if (Instance.tag == "villager")
            {
                //67 63 63 : color text
                //138 138 138 : color background
                DialogManger.Instance.nameText.text = dialogue.name;
                if (text == "NV1")
                {
                    var check = GameObject.Find("Q_NV1");
                    if (check)
                    {
                        DialogManger.Instance.dialogueText.text = RandomText2();

                        ctnText.color = new Color32(138, 138, 138, 255);
                        gpText.color = new Color32(138, 138, 138, 255);
                        continueButton.enabled = false;
                        givePresentButton.enabled = false;
                        return;
                    }
                    else 
                    {
                        if(countItem == 0)
                        {
                            DialogManger.Instance.dialogueText.text = RandomText1();// "Th?t bu?n khi ch?a ???c t?ng qu� Gi�ng sinh :( ";

                            ctnText.color = new Color32(138, 138, 138, 255);
                            gpText.color = new Color32(138, 138, 138, 255);
                            continueButton.enabled = false;
                            givePresentButton.enabled = false;
                            return;
                        }
                        else
                        {
                            ctnText.color = new Color32(138, 138, 138, 255);
                            gpText.color = new Color32(67, 63, 63, 255);
                            continueButton.enabled = false;
                            givePresentButton.enabled = true;
                        }
                    }
                }
                else if (text == "NV2")
                {
                    var check = GameObject.Find("Q_NV2");
                    if (check)
                    {
                        DialogManger.Instance.dialogueText.text = RandomText2();

                        ctnText.color = new Color32(138, 138, 138, 255);
                        gpText.color = new Color32(138, 138, 138, 255);
                        continueButton.enabled = false;
                        givePresentButton.enabled = false;
                        return;
                    }
                    else
                    {
                        if (countItem == 0)
                        {
                            DialogManger.Instance.dialogueText.text = RandomText1();// "Th?t bu?n khi ch?a ???c t?ng qu� Gi�ng sinh :( ";

                            ctnText.color = new Color32(138, 138, 138, 255);
                            gpText.color = new Color32(138, 138, 138, 255);
                            continueButton.enabled = false;
                            givePresentButton.enabled = false;
                            return;
                        }
                        else
                        {
                            ctnText.color = new Color32(138, 138, 138, 255);
                            gpText.color = new Color32(67, 63, 63, 255);
                            continueButton.enabled = false;
                            givePresentButton.enabled = true;
                        }
                    }
                }
                else if (text == "NV3")
                {
                    var check = GameObject.Find("Q_NV3");
                    if (check)
                    {
                        DialogManger.Instance.dialogueText.text = RandomText2();

                        ctnText.color = new Color32(138, 138, 138, 255);
                        gpText.color = new Color32(138, 138, 138, 255);
                        continueButton.enabled = false;
                        givePresentButton.enabled = false;
                        return;
                    }
                    else
                    {
                        if (countItem == 0)
                        {
                            DialogManger.Instance.dialogueText.text = RandomText1();// "Th?t bu?n khi ch?a ???c t?ng qu� Gi�ng sinh :( ";

                            ctnText.color = new Color32(138, 138, 138, 255);
                            gpText.color = new Color32(138, 138, 138, 255);
                            continueButton.enabled = false;
                            givePresentButton.enabled = false;
                            return;
                        }
                        else
                        {
                            ctnText.color = new Color32(138, 138, 138, 255);
                            gpText.color = new Color32(67, 63, 63, 255);
                            continueButton.enabled = false;
                            givePresentButton.enabled = true;
                        }
                    }
                }
                else if (text == "NV4")
                {
                    var check = GameObject.Find("Q_NV4");
                    if (check)
                    {
                        DialogManger.Instance.dialogueText.text = RandomText2();

                        ctnText.color = new Color32(138, 138, 138, 255);
                        gpText.color = new Color32(138, 138, 138, 255);
                        continueButton.enabled = false;
                        givePresentButton.enabled = false;
                        return;
                    }
                    else
                    {
                        if (countItem == 0)
                        {
                            DialogManger.Instance.dialogueText.text = RandomText1();// "Th?t bu?n khi ch?a ???c t?ng qu� Gi�ng sinh :( ";

                            ctnText.color = new Color32(138, 138, 138, 255);
                            gpText.color = new Color32(138, 138, 138, 255);
                            continueButton.enabled = false;
                            givePresentButton.enabled = false;
                            return;
                        }
                        else
                        {
                            ctnText.color = new Color32(138, 138, 138, 255);
                            gpText.color = new Color32(67, 63, 63, 255);
                            continueButton.enabled = false;
                            givePresentButton.enabled = true;
                        }
                    }

                }
            }
            else if (Instance.tag == "santa")
            {
                gpText.color = new Color32(138, 138, 138, 255);
                ctnText.color = new Color32(67, 63, 63, 255);

                givePresentButton.enabled = false;
                continueButton.enabled = true;
            }


            FindObjectOfType<DialogManger>().StartDialogue(dialogue, check ? 1 : 0);
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("1");
            conver.SetActive(false);
        }
    }

    private string RandomText1()
    {
        var rd = StrBiome();
        return textForSad[rd];
    }
    private string RandomText2()
    {
        return textForThanks[StrBiome()];
    }

    private static int StrBiome()
    {
        return Random.Range(0, 4);
    }

    private void SetText()
    {
        textForSad.Clear();
        textForThanks.Clear();
        textForWish.Clear();
       /* textForSad = new List<string>();
        textForThanks = new List<string>();
        textForWish = new List<string>();*/
        foreach (string sentence in dialogue.textForSad)
        {
            Debug.Log(sentence);
            textForSad.Add(sentence);
        }
        foreach (string sentence in dialogue.textForThanks)
        {
            textForThanks.Add(sentence);
        }
        foreach (string sentence in dialogue.textForWish)
        {
            textForWish.Add(sentence);
        }
    }
}
