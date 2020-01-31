using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponInfoUI : MonoBehaviour
{
    public static WeaponInfoUI Instance { get; private set; }

    public Text WeaponName;
    public Text WeaponClipContent;
    public Text AmmoTypeCount;
    
    void OnEnable()
    {
        Instance = this;
    }

    public void UpdateWeaponName(string name)
    {
        WeaponName.text = name;
    }

    public void UpdateClipInfo(Weapon weapon)
    {
        WeaponClipContent.text = weapon.ClipContent.ToString();
    }

    public void UpdateAmmoAmount(int amount)
    {
        AmmoTypeCount.text = amount.ToString();
    }
}
