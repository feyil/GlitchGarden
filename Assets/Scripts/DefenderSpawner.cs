using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;

    private void OnMouseDown()
    {
        Debug.Log("Mouse was clicked");
        SpawnDefender(GetSquareClicked());
    }

    private void SpawnDefender(Vector2 worldPos)
    {
        // as Defender allow to see in inspector
        var newDefender = Instantiate(defender, worldPos, Quaternion.identity) as Defender; 
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);

        var gridPos = SnapToGrid(worldPos);

        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(newX, newY);
    }

    public void SetSelectedDefender(Defender defenderToSelect) 
    {
        defender = defenderToSelect;
    }
}
