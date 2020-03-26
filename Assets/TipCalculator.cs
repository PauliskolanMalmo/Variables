using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    public int bill = 40;
    public float tip = 20.0f;
    public float totalAmount;

    void Start()
    {
        float tipAmount = bill * (tip / 100);
        totalAmount = bill + tipAmount;

        Debug.Log("Your bill is: " + bill + " and your amount is: " + tipAmount + " So you owe: " + totalAmount);
    }


}
