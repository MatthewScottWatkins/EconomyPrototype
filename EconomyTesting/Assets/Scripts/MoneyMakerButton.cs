using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyMakerButton : MonoBehaviour
{
    private Gamemanager gameMgr;
    private int goldValue;
    private int totalGoldValue;

    public DataWriter dataWriter;

    private void Awake()
    {
        gameMgr = FindObjectOfType<Gamemanager>();
        dataWriter = FindObjectOfType<DataWriter>();
    }

    public void MakeMoney()
    {
        gameMgr.upgradeNo = false;

        totalGoldValue = 0;
        gameMgr.goldValuesList.Clear();
        gameMgr.itemTypesSoldList.Clear();

        for (int i = 0; i < gameMgr.inventorySlots; i++)
        {
            goldValue = Random.Range(gameMgr.itemList[i].minValue, gameMgr.itemList[i].maxValue);
            gameMgr.itemTypesSoldList.Add(gameMgr.itemList[i].itemType.ToString());
            gameMgr.CheckItemType(gameMgr.itemList[i]);

            gameMgr.goldCount += goldValue;

            gameMgr.itemTextList[i].text = "Empty";
            gameMgr.itemList[i] = null;

            gameMgr.goldValuesList.Add(goldValue);

            totalGoldValue += goldValue;
        }

        gameMgr.goldPerDayList.Add(totalGoldValue);

        dataWriter.CreateText(totalGoldValue);

        gameMgr.goldGainedText.text = "+" + totalGoldValue.ToString() + "g";

        gameObject.GetComponent<Button>().interactable= false;
        gameMgr.buttonsList.endDayButton.interactable = true;
        gameMgr.buttonsList.upgradeButton.interactable = true;
    }
}
