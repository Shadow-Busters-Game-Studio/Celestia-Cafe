using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Settings : MonoBehaviour
{
    public void SaveName(string name){
        PlayerPrefs.SetString("Player Name", name);
    }
}
