using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2Score : MonoBehaviour
{
    public static int p2Score = 0;
    Text p2score;

    void Start()
    {
        p2score = GetComponent<Text>();
    }

    void Update()
    {
        p2score.text = "P2 - " + p2Score;
    }
}
