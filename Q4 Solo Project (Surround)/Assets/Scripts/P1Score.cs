using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1Score : MonoBehaviour
{
    public static int p1Score = 0;
    Text p1score;

    void Start()
    {
        p1score = GetComponent<Text>();
    }

    void Update()
    {
        p1score.text = "P1 - " + p1Score;
    }
}
