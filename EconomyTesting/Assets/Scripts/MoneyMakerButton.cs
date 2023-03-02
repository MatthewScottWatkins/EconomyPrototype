using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyMakerButton : MonoBehaviour
{
    public Gamemanager gameMgr;
    private int goldValue;
    public List<int> goldValues;
    public List<string> itemTypesSold;
    public List<int> goldPerDay;
    public int totalGoldValue;
    
    public GameObject nextDayButton;
    public GameObject upgradeButton;

    public void MakeMoney()
    {
        gameMgr.upgradeNo = false;

        totalGoldValue = 0;
        goldValues.Clear();
        itemTypesSold.Clear();

        for (int i = 0; i < gameMgr.inventorySlots; i++)
        {
            goldValue = Random.Range(gameMgr.itemList[i].minValue, gameMgr.itemList[i].maxValue);
            itemTypesSold.Add(gameMgr.itemList[i].itemType);

            gameMgr.goldCount += goldValue;

            gameMgr.itemTextList[i].text = "Empty";
            gameMgr.itemList[i] = null;

            goldValues.Add(goldValue);

            totalGoldValue += goldValue;
        }

        goldPerDay.Add(totalGoldValue);

        gameMgr.goldGainedText.text = "+" + totalGoldValue.ToString() + "g";

        gameObject.GetComponent<Button>().interactable= false;
        nextDayButton.GetComponent<Button>().interactable = true;
        upgradeButton.GetComponent<Button>().interactable = true;
    }
}
