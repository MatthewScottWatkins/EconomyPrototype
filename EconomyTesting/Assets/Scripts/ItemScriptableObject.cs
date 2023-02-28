using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "Items/item")]
public class ItemScriptableObject : ScriptableObject
{
    public string itemName;
    public string itemType;
    public int minValue;
    public int maxValue;

}
