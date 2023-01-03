using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;
    public int countItem;
    public int amountReceivedPerson;

    public GameObject qua1;
    public GameObject qua2;
    public GameObject qua3;
    public GameObject qua4;

    private void Awake()
    {
        Instance = this;
        countItem = 0;
        amountReceivedPerson = 0;
    }
    public void Add(Item item)
    {
        Items.Add(item);
    }
    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public void ListItems()
    {
        /*foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }*/
        /*foreach (var item in Items)
        {
            //GameObject obj = Instantiate(InventoryItem, ItemContent);
            *//*var itemName = obj.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            Debug.Log(itemName);
            Debug.Log(itemIcon);
            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;*//*

            Debug.Log(Items);
            
        }*/

        countItem++;
        if (PlayerController.Instance.Health > 100) PlayerController.Instance.Health = 100;
        TextMeshProUGUI healthText = GameObject.Find("HealthText").GetComponent<TextMeshProUGUI>();
        healthText.text = PlayerController.Instance.Health.ToString() + "/100";

        GameObject[] count = GameObject.FindGameObjectsWithTag("count");
        count[0].GetComponent<TextMeshProUGUI>().text = countItem.ToString();
    }
    public void GiveItems()
    {
        var text = DialogueTrigger.Instance.name;

        Button continueButton = GameObject.Find("ContinueButton").GetComponent<Button>();
        Button givePresentButton = GameObject.Find("GivePresentButton").GetComponent<Button>();
        TextMeshProUGUI ctnText = GameObject.Find("ContinueText").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI gpText = GameObject.Find("GivePresentText").GetComponent<TextMeshProUGUI>();

        if (text == "NV1")
        {
            qua1.SetActive(true);
        }
        else if (text == "NV2")
        {
            qua2.SetActive(true);
        }
        else if (text == "NV3")
        {
            qua3.SetActive(true);
        }
        else if (text == "NV4")
        {
            qua4.SetActive(true);

        }
        countItem--;
        amountReceivedPerson++;
        PlayerController.Instance.Health += 20;
        if (PlayerController.Instance.Health > 100) PlayerController.Instance.Health = 100;
        TextMeshProUGUI healthText = GameObject.Find("HealthText").GetComponent<TextMeshProUGUI>();
        healthText.text = PlayerController.Instance.Health.ToString() + "/100";

        DialogManger.Instance.dialogueText.text = RandomThanksText();
                ctnText.color = new Color32(138, 138, 138, 255);
                gpText.color = new Color32(138, 138, 138, 255);
                continueButton.enabled = false;
                givePresentButton.enabled = false;
        if (countItem < 1) countItem = 0;
        //set win
        if(amountReceivedPerson == 4)
        {
            //code for win
        }    
        GameObject[] count = GameObject.FindGameObjectsWithTag("count");
        count[0].GetComponent<TextMeshProUGUI>().text = countItem.ToString();

        GameObject[] personText = GameObject.FindGameObjectsWithTag("PersonText");
        personText[0].GetComponent<TextMeshProUGUI>().text = amountReceivedPerson.ToString() + "/4";
        checkWin();

    }
    private string RandomThanksText()
    {
        var array = DialogueTrigger.Instance.textForWish;

        return array[StrBiome()];
    }

    private static int StrBiome()
    {
        return Random.Range(0, 4);
    }

    private void checkWin()
    {
        if (amountReceivedPerson == 4)
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            LevelLoader.Instance.LoadWin();
    }
}
