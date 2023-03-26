using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { Loot, Armour, Valauble, Weapon, Artwork, Food}

[CreateAssetMenu(fileName = "New item", menuName = "Items/item")]
public class ItemScriptableObject : ScriptableObject
{
    public string itemName;
    public ItemType itemType;
    public int minValue;
    public int maxValue;

}
