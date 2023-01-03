using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemRemove : MonoBehaviour
{
    public Item Item;

    //public Button yourButton;
   /* void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        GiveAGift();
    }*/

    public void GiveAGift()
    {
        InventoryManager.Instance.GiveItems();
    }

}
