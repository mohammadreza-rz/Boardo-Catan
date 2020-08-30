﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    private void OnMouseDown()
    {
        ChangeRoadColor();
        Debug.Log(gameObject.name);
    }

    private void ChangeRoadColor()
    {
        var road = GetComponent<SpriteRenderer>();
        road.color = MainScreen.PlayerColor;
    }
}