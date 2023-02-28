using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public Gamemanager gameMgr;

    public int upgradeTier = 0;
    private void Update()
    {
        if (gameMgr.goldCount < gameMgr.upgradeCost)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
        else { gameObject.GetComponent<Button>().interactable = true; }
    }
    public void UpgradePress()
    {
        switch (upgradeTier)
        {
                case 0:
            {
                    upgradeTier = 1;
                    gameMgr.upgradeCost = 500;
                    gameMgr.goldCount -= 500;
                    gameMgr.inventorySlots = 6;

                    gameMgr.itemFiveText.gameObject.SetActive(true);
                    gameMgr.itemSixText.gameObject.SetActive(true);
                    gameMgr.itemTextList.Add(gameMgr.itemFiveText);
                    gameMgr.itemTextList.Add(gameMgr.itemSixText);

                    gameMgr.itemList.Add(gameMgr.itemFive);
                    gameMgr.itemList.Add(gameMgr.itemSix);

                        break;
            }
                case 1:
            {
                    upgradeTier = 2;
                    gameMgr.upgradeCost = 1000;
                    gameMgr.goldCount -= 1000;
                    gameMgr.inventorySlots = 8;

                    gameMgr.itemSevenText.gameObject.SetActive(true);
                    gameMgr.itemEightText.gameObject.SetActive(true);
                    gameMgr.itemTextList.Add(gameMgr.itemSevenText);
                    gameMgr.itemTextList.Add(gameMgr.itemEightText);

                    gameMgr.itemList.Add(gameMgr.itemSeven);
                    gameMgr.itemList.Add(gameMgr.itemEight);

                        break;
            }
                case 2:
            {
                    upgradeTier = 3;
                    gameMgr.upgradeCost = 2000;
                    gameMgr.goldCount -= 2000;
                    gameMgr.inventorySlots = 10;

                    gameMgr.itemNineText.gameObject.SetActive(true);
                    gameMgr.itemTenText.gameObject.SetActive(true);
                    gameMgr.itemTextList.Add(gameMgr.itemNineText);
                    gameMgr.itemTextList.Add(gameMgr.itemTenText);
                    

                    gameMgr.itemList.Add(gameMgr.itemNine);
                    gameMgr.itemList.Add(gameMgr.itemTen);
                    

                        break;
            }
                case 3:
                {
                    upgradeTier = 4;
                    gameMgr.upgradeCost = 3000;
                    gameMgr.goldCount -= 3000;
                    gameMgr.inventorySlots = 12;

                    gameMgr.itemElevenText.gameObject.SetActive(true);
                    gameMgr.itemTwelveText.gameObject.SetActive(true);
                    gameMgr.itemTextList.Add(gameMgr.itemElevenText);
                    gameMgr.itemTextList.Add(gameMgr.itemTwelveText);

                    gameMgr.itemList.Add(gameMgr.itemEleven);
                    gameMgr.itemList.Add(gameMgr.itemTwelve);
                        break;
                }
            case 4:
                {
                    upgradeTier = 5;
                    gameMgr.inventorySlots = 16;

                    gameMgr.itemThirteenText.gameObject.SetActive(true);
                    gameMgr.itemFourteenText.gameObject.SetActive(true);
                    gameMgr.itemFifthteenText.gameObject.SetActive(true);
                    gameMgr.itemSixteenText.gameObject.SetActive(true);
                    gameMgr.itemTextList.Add(gameMgr.itemThirteenText);
                    gameMgr.itemTextList.Add(gameMgr.itemFourteenText);
                    gameMgr.itemTextList.Add(gameMgr.itemFifthteenText);
                    gameMgr.itemTextList.Add(gameMgr.itemSixteenText);

                    gameMgr.itemList.Add(gameMgr.itemThirteen);
                    gameMgr.itemList.Add(gameMgr.itemFourteen);
                    gameMgr.itemList.Add(gameMgr.itemFifthteen);
                    gameMgr.itemList.Add(gameMgr.itemSixteen);

                    gameObject.SetActive(false);
                    break;
                }

        }
    }

    public void UpgradeReset()
    {
        upgradeTier = 0;

        gameMgr.itemFiveText.gameObject.SetActive(false);
        gameMgr.itemSixText.gameObject.SetActive(false);
        gameMgr.itemTextList.Remove(gameMgr.itemFiveText);
        gameMgr.itemTextList.Remove(gameMgr.itemSixText);

        gameMgr.itemList.Remove(gameMgr.itemFive);
        gameMgr.itemList.Remove(gameMgr.itemSix);

        gameMgr.itemSevenText.gameObject.SetActive(false);
        gameMgr.itemEightText.gameObject.SetActive(false);
        gameMgr.itemTextList.Remove(gameMgr.itemSevenText);
        gameMgr.itemTextList.Remove(gameMgr.itemEightText);

        gameMgr.itemList.Remove(gameMgr.itemSeven);
        gameMgr.itemList.Remove(gameMgr.itemEight);

        gameMgr.itemNineText.gameObject.SetActive(false);
        gameMgr.itemTenText.gameObject.SetActive(false);
        gameMgr.itemTextList.Remove(gameMgr.itemNineText);
        gameMgr.itemTextList.Remove(gameMgr.itemTenText);


        gameMgr.itemList.Remove(gameMgr.itemNine);
        gameMgr.itemList.Remove(gameMgr.itemTen);

        gameMgr.itemElevenText.gameObject.SetActive(false);
        gameMgr.itemTwelveText.gameObject.SetActive(false);
        gameMgr.itemTextList.Remove(gameMgr.itemElevenText);
        gameMgr.itemTextList.Remove(gameMgr.itemTwelveText);

        gameMgr.itemList.Remove(gameMgr.itemEleven);
        gameMgr.itemList.Remove(gameMgr.itemTwelve);

        gameMgr.itemThirteenText.gameObject.SetActive(false);
        gameMgr.itemFourteenText.gameObject.SetActive(false);
        gameMgr.itemFifthteenText.gameObject.SetActive(false);
        gameMgr.itemSixteenText.gameObject.SetActive(false);
        gameMgr.itemTextList.Remove(gameMgr.itemThirteenText);
        gameMgr.itemTextList.Remove(gameMgr.itemFourteenText);
        gameMgr.itemTextList.Remove(gameMgr.itemFifthteenText);
        gameMgr.itemTextList.Remove(gameMgr.itemSixteenText);

        gameMgr.itemList.Remove(gameMgr.itemThirteen);
        gameMgr.itemList.Remove(gameMgr.itemFourteen);
        gameMgr.itemList.Remove(gameMgr.itemFifthteen);
        gameMgr.itemList.Remove(gameMgr.itemSixteen);
    }
}
