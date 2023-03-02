using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject scavengeButton;
    public GameObject upgradeButton;
    public GameObject moneyMakerButton;
    public GameObject endDayButton;

    public void StartDay()
    {
        gameObject.SetActive(false);
        scavengeButton.SetActive(true);
        upgradeButton.SetActive(true);
        moneyMakerButton.SetActive(true);
        endDayButton.SetActive(true);
    }
}
