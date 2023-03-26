using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScavengeButton : MonoBehaviour
{
    private Gamemanager gameMgr;
    private int itemsFound = 0;
    private int item;
    public int randomValue;
    public List<int> randomValuesList= new List<int>();

    private void Awake()
    {
        gameMgr = FindObjectOfType<Gamemanager>();
    }

    public void Scavenge()
    {
        randomValuesList.Clear();

        for(int i = 0; i < gameMgr.inventorySlots; i++)
        {
            item = Random.Range(0, gameMgr.amountOfItems);
            item += gameMgr.dropBonus;

            randomValue = Random.Range(0, 10);

            randomValuesList.Add(randomValue);

            if (randomValue >= 5)
            {
                item -= gameMgr.dropChance;

                if (item < 0) { item = 0; }
            }

            if (gameMgr.dayCount < 5)
            {
                item += gameMgr.dropBonus;

                if(item > gameMgr.amountOfItems) { item = gameMgr.amountOfItems;}
            }

            gameMgr.upgradeNo = true;

            switch (itemsFound)
            {
                case 0:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 1:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 2:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 3:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 4:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 5:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 6:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 7:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 8:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 9:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 10:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 11:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 12:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 13:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 14:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 15:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
                case 16:
                    {
                        gameMgr.itemList[itemsFound] = gameMgr.possibleItems[item];
                        gameMgr.itemTextList[itemsFound].text = gameMgr.itemList[itemsFound].itemName;
                        itemsFound++;
                        break;
                    }
            }
        }

        itemsFound = 0;
        gameObject.GetComponent<Button>().interactable= false;
        gameMgr.buttonsList.upgradeButton.interactable = false;
        gameMgr.buttonsList.moneyMakerButton.interactable = true;
    }
}
