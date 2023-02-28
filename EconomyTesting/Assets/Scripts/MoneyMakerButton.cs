using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyMakerButton : MonoBehaviour
{
    public Gamemanager gameMgr;
    public int goldValue;
    public int totalGoldValue;
    
    public GameObject nextDayButton;

    public void MakeMoney()
    {
        totalGoldValue = 0;

        for (int i = 0; i < gameMgr.inventorySlots; i++)
        {
            goldValue = Random.Range(gameMgr.itemList[i].minValue, gameMgr.itemList[i].maxValue);
            gameMgr.goldCount += goldValue;
            gameMgr.itemTextList[i].text = "Empty";
            gameMgr.itemList[i] = null;
            totalGoldValue += goldValue;
        }
        gameMgr.goldGainedText.text = "+" + totalGoldValue.ToString() + "g";
        gameObject.GetComponent<Button>().interactable= false;
        nextDayButton.GetComponent<Button>().interactable = true;
    }
}
