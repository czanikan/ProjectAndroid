﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isComplete;

    public CustomConfiguration cc;

    public GameObject victoryLabel;

    void Start()
    {
        isComplete = false;
        victoryLabel.SetActive(false);
    }

    void Update()
    {
        if(isComplete)
        {
            Victory();
        }
    }

    void Victory()
    {
        victoryLabel.SetActive(true);
        cc.IncrementScore();
        cc.SendScoreDataToServer();
    }
    
    
}
