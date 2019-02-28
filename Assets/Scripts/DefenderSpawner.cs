﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        Debug.Log("Mouse was clicked");
        SpawnDefender(GetSquareClicked());
    }

    private void SpawnDefender(Vector2 worldPos)
    {
        // as GameObject allow to see in inspector
        GameObject newDefender = Instantiate(defender, worldPos, Quaternion.identity) as GameObject; 
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);

        return worldPos;
    }
}
