using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndDayButton : MonoBehaviour
{
    public Gamemanager gameMgr;
    public GameObject scavengeButton;

    public void EndDay()
    {
        gameMgr.dayCount++;
        gameMgr.goldCount -= (gameMgr.fatherTax + gameMgr.motherTax + gameMgr.sisterTax + gameMgr.brotherTax + gameMgr.goblinCaveTax);
        scavengeButton.GetComponent<Button>().interactable = true;
    }
}
