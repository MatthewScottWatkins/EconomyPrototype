using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataWriter : MonoBehaviour
{
    public Gamemanager gameMgr;
    private void Start()
    {
        gameMgr = FindObjectOfType<Gamemanager>();
    }

    public void CreateText(int contentIndex)
    {
        string path = Application.dataPath + "/GoblinData.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "List: \n\n");
        }

        string content = contentIndex.ToString() + "\n";

        File.AppendAllText(path, content);
    }

}
