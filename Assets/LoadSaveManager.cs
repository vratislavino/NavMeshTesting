using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSaveManager
{

    private static LoadSaveManager instance = new LoadSaveManager();

    public static LoadSaveManager Instance => instance;

    private LoadSaveManager() { }

    public void Save(Vector3 toSave)
    {
        PlayerPrefs.SetFloat("playerX", toSave.x);
        PlayerPrefs.SetFloat("playerY", toSave.y);
        PlayerPrefs.SetFloat("playerZ", toSave.z);

        string json = JsonUtility.ToJson(toSave);
        Debug.Log(json);
    }

    public Vector3 Load()
    {
        Vector3 defaultPos = new Vector3(3, 1, -3);
        if(PlayerPrefs.HasKey("playerX"))
        {
            defaultPos.x = PlayerPrefs.GetFloat("playerX");
            defaultPos.y = PlayerPrefs.GetFloat("playerY");
            defaultPos.z = PlayerPrefs.GetFloat("playerZ");
        }
        return defaultPos;
    }


}
