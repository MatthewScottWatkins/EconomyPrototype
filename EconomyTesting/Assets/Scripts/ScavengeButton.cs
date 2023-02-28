using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScavengeButton : MonoBehaviour
{
    public Gamemanager gameMgr;
    public int itemsFound = 0;
    public int item;

    public GameObject MoneyMakerButton;

    public void Scavenge()
    {
        for(int i = 0; i < gameMgr.inventorySlots; i++)
        {
            item = Random.Range(0, gameMgr.amountOfItems);

            if (item > gameMgr.dropChance)
            {
                item = - -(Random.Range(0, gameMgr.dropChance) + gameMgr.dropBonus);
            }
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
        MoneyMakerButton.GetComponent<Button>().interactable = true;
    }
}
