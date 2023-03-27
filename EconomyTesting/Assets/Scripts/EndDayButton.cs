using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndDayButton : MonoBehaviour
{
    private Gamemanager gameMgr;

    private void Awake()
    {
        gameMgr = FindObjectOfType<Gamemanager>();
    }

    public void EndDay()
    {
        gameMgr.dayCount++;
        gameMgr.goldCount -= (gameMgr.fatherTax + gameMgr.motherTax + gameMgr.sisterTax + gameMgr.brotherTax + gameMgr.goblinCaveTax);
        gameMgr.buttonsList.scavengeButton.interactable = true;
        gameObject.GetComponent<Button>().interactable = false;
        gameMgr.CheckForDeath();

        gameMgr.UpdateTaxes();
    }
}
