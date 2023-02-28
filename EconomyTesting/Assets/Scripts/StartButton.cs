using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject scavengeButton;
    public GameObject upgradeButton;
    public void StartDay()
    {
        this.gameObject.SetActive(false);
        scavengeButton.SetActive(true);
        upgradeButton.SetActive(true);
    }
}
