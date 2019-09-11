﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Renderer renderer;

    private float timeRemaining = 0;

    private void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
    }

    private void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining <= 0)
        {
            ChangeColour();
            timeRemaining += 1f;
        }
    }

    private void ChangeColour()
    {
        Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        renderer.material.color = randomColor;
    }
}
