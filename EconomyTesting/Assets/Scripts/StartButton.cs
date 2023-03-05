using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    private Gamemanager gameMgr;

    private void Start()
    {
        gameMgr = FindObjectOfType<Gamemanager>();
    }
    public void StartDay()
    {
        gameObject.SetActive(false);
        gameMgr.buttonsList.scavengeButton.gameObject.SetActive(true);
        gameMgr.buttonsList.upgradeButton.gameObject.SetActive(true);
        gameMgr.buttonsList.moneyMakerButton.gameObject.SetActive(true);
        gameMgr.buttonsList.endDayButton.gameObject.SetActive(true);
    }
}
