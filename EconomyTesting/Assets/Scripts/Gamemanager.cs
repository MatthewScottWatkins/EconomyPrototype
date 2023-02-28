using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public int goldCount;

    public int startingGoldCount;

    public int dayCount;

    public int upgradeCost;

    public int inventorySlots;

    public int dropChance;
    public int dropBonus;

    public TextMeshProUGUI goldCountText;
    public TextMeshProUGUI dayCountText;
    public TextMeshProUGUI upgradeCostText;

    public List<TextMeshProUGUI> itemTextList = new List<TextMeshProUGUI>();
    #region ItemtextObjects
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

    public ItemScriptableObject[] possibleItems;
    public int amountOfItems;

    #region ItemObjects
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

    public List<ItemScriptableObject> itemList = new List<ItemScriptableObject>();

    private void Awake()
    {
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
        dayCountText.text = "Day " + dayCount.ToString();
        upgradeCostText.text = upgradeCost.ToString() + "g";
    }
}
