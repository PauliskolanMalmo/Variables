﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    public float attackStrength;

    void Start()
    {
        Debug.Log("Name: " + itemName);
        Debug.Log("Description: " + itemDescription);
        Debug.Log("Attack: " + attackStrength);
    }

}
