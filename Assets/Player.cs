using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public string myName = "Adam";
    public int myAge = 22;
    public float mySpeed = 10.2f;
    public int health = 100;
    public int score = 120;
    public int hasAllKeys;
    public int ammoCount;

    void Start()
    {
        Debug.Log("My name is" + myName + " and is am " + myAge + " years old");
        Debug.Log("Speed: " + mySpeed);
        Debug.Log("Health: " + health);
        Debug.Log("Score: " + score);
        Debug.Log("Has All Keys: " + hasAllKeys);
        Debug.Log("Ammo Count " + ammoCount);

    }


}