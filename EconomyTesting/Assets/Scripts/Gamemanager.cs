using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

enum FamilyMember { father, mother, sister, brother }

public class Gamemanager : MonoBehaviour
{
    #region Varaibles
    #region Counts
    [Header("Counts")]
    public int goldCount;
    public int startingGoldCount;
    public int dayCount;
    #endregion Counts

    public int upgradeCost;
    public int inventorySlots;

    public int dropChance;
    public int dropBonus;

    #region Taxes
    [Header("Taxes")]
    public int fatherTax;
    public int motherTax;
    public int sisterTax;
    public int brotherTax;
    public int goblinCaveTax;
    public int allTax;


    FamilyMember familyMember;
    string familyUpdate;
    public GameObject infoPrefab;
    public GameObject infoPanel;
    public GameObject infoPanelParent;
    public GameObject infoPanelNotification;
    #endregion Taxes

    #region TextObjects
    [Header("Text Objects")]
    public TextMeshProUGUI goldCountText;
    public TextMeshProUGUI currentTaxText;
    public TextMeshProUGUI dayCountText;
    public TextMeshProUGUI upgradeCostText;
    public TextMeshProUGUI goldGainedText;
    #endregion TextObjects

    #region ItemTextObjects
    [Header("Item Text Objects")]
    public TextMeshProUGUI itemOneText;
    public TextMeshProUGUI itemTwoText;
    public TextMeshProUGUI itemThreeText;
    public TextMeshProUGUI itemFourText;
    public TextMeshProUGUI itemFiveText;
    public TextMeshProUGUI itemSixText;
    public TextMeshProUGUI itemSevenText;
    public TextMeshProUGUI itemEightText;
    public TextMeshProUGUI itemNineText;
    public TextMeshProUGUI itemTenText;
    public TextMeshProUGUI itemElevenText;
    public TextMeshProUGUI itemTwelveText;
    public TextMeshProUGUI itemThirteenText;
    public TextMeshProUGUI itemFourteenText;
    public TextMeshProUGUI itemFifthteenText;
    public TextMeshProUGUI itemSixteenText;
    #endregion ItemTextObjects

    #region Lists
    [Header("Lists")]
    public List<ItemScriptableObject> itemList = new List<ItemScriptableObject>();
    public List<TextMeshProUGUI> itemTextList = new List<TextMeshProUGUI>();
    public List<int> goldValuesList;
    public List<string> itemTypesSoldList;
    public List<int> goldPerDayList;
    public List<int> upgradeBuyDaysList;
    #endregion Lists

    public int typeLoot;
    public int typeValuable;
    public int typeWeapon;
    public int typeArmour;
    public int typeArtwork;
    public int typeFood;

    #region ItemObjects
    [Header("Item Objects")]
    public ItemScriptableObject itemOne;
    public ItemScriptableObject itemTwo;
    public ItemScriptableObject itemThree;
    public ItemScriptableObject itemFour;
    public ItemScriptableObject itemFive;
    public ItemScriptableObject itemSix;
    public ItemScriptableObject itemSeven;
    public ItemScriptableObject itemEight;
    public ItemScriptableObject itemNine;
    public ItemScriptableObject itemTen;
    public ItemScriptableObject itemEleven;
    public ItemScriptableObject itemTwelve;
    public ItemScriptableObject itemThirteen;
    public ItemScriptableObject itemFourteen;
    public ItemScriptableObject itemFifthteen;
    public ItemScriptableObject itemSixteen;
    #endregion ItemObjects

    public ItemScriptableObject[] possibleItems;
    public int amountOfItems;

    public GameObject loseScreen;


    #region Checks
    public bool upgradeNo;
    #endregion Checks

    public ButtonsList buttonsList;
    public DataWriter dataWriter;
    #endregion Variables

    #region Functions
    private void Awake()
    {
        buttonsList = FindObjectOfType<ButtonsList>();
        dataWriter = FindObjectOfType<DataWriter>();

        //item objects
        itemList.Add(itemOne);
        itemList.Add(itemTwo);
        itemList.Add(itemThree);
        itemList.Add(itemFour);

        //text objects
        itemTextList.Add(itemOneText);
        itemTextList.Add(itemTwoText);
        itemTextList.Add(itemThreeText);
        itemTextList.Add(itemFourText);
    }

    private void Start()
    {
        goldCount = startingGoldCount;
        dayCount = 1;
        amountOfItems = possibleItems.Length - 1;
    }

    private void Update()
    {
        goldCountText.text = goldCount.ToString() + "g";
        currentTaxText.text = "-" + allTax.ToString() + "g";
        dayCountText.text = "Day " + dayCount.ToString();
        upgradeCostText.text = upgradeCost.ToString() + "g";
        allTax = fatherTax + motherTax + brotherTax + sisterTax + goblinCaveTax;
    }

    public void RestartGame()
    {
        loseScreen.SetActive(false);
        goldCount = startingGoldCount;
        dayCount = 1;
        inventorySlots = 4;
        upgradeCost = 100;
        goldPerDayList.Clear();
        upgradeBuyDaysList.Clear();
    }

    public void CheckForDeath()
    {
        if (goldCount <= 0)
        {
            loseScreen.SetActive(true);
        }
    }

    public void UpdateTaxes()
    {
        if (dayCount == 10 || dayCount == 20 || dayCount == 30 || dayCount == 40 || dayCount == 50)
        {

            string familyMemeberChosen = "";
            int taxIncrease = 0;

            taxIncrease = Random.Range(1, 12);
            int familyIndex = 0;

            familyIndex = Random.Range(0, 3);

            switch (familyIndex)
            {
                case 0:
                    {
                        familyMember = FamilyMember.sister;
                        break;
                    }
                case 1:
                    {
                        familyMember = FamilyMember.mother;
                        break;
                    }
                case 2:
                    {
                        familyMember = FamilyMember.brother;
                        break;
                    }
                case 3:
                    {
                        familyMember = FamilyMember.father;
                        break;
                    }
            }
            switch (familyMember)
            {
                case FamilyMember.sister:
                    {
                        familyMemeberChosen = "Your Sister ";
                        sisterTax += taxIncrease;
                        break;
                    }
                case FamilyMember.mother:
                    {
                        familyMemeberChosen = "Your Mother ";
                        motherTax += taxIncrease;
                        break;
                    }
                case FamilyMember.brother:
                    {
                        familyMemeberChosen = "Your Brother ";
                        brotherTax += taxIncrease;
                        break;
                    }
                case FamilyMember.father:
                    {
                        familyMemeberChosen = "Your Father ";
                        fatherTax += taxIncrease;
                        break;
                    }
            }

            familyUpdate = familyMemeberChosen + "has increased their gold needs by: " + taxIncrease.ToString();

            GameObject clone;

            infoPanelNotification.SetActive(true);

            clone = Instantiate(infoPrefab, infoPanel.transform);

            clone.GetComponent<TextUpdater>().infoText.text = familyUpdate;
        }
    }

    public void CheckItemType(ItemScriptableObject item)
    {
        switch (item.itemType)
        {
            case ItemType.Loot:
                {
                    typeLoot++;
                    break;
                }
            case ItemType.Armour:
                {
                    typeArmour++;
                    break;
                }
            case ItemType.Artwork:
                {
                    typeArtwork++;
                    break;
                }
            case ItemType.Weapon:
                {
                    typeWeapon++;
                    break;
                }
            case ItemType.Valauble:
                {
                    typeValuable++;
                    break;
                }
            case ItemType.Food:
                {
                    typeFood++;
                    break;
                }
        }
    }

    #endregion Functions
}