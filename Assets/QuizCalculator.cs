using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{

    public float q1, q2, q3, q4, q5;
    void Start()
    {
        q1 = Random.Range(0f, 100f);
        q2 = Random.Range(0f, 100f);
        q3 = Random.Range(0f, 100f);
        q4 = Random.Range(0f, 100f);
        q5 = Random.Range(0f, 100f);

        float average = (q1 + q2 + q3 + q4 + q5) / 5;

        Debug.Log("Average: " + average);
        Debug.Log("Average: " + Mathf.Round(average * 100f) / 100f);

        //Alt. way - https://answers.unity.com/questions/535424/round-float-with-2-decimal.html
        Debug.Log("Average: " + System.Math.Round(average, 2));


    }


    void Update()
    {

    }
}
