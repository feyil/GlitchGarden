using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        Debug.Log("Mouse was clicked");
        SpawnDefender();
    }

    private void SpawnDefender()
    {
        // as GameObject allow to see in inspector
        GameObject newDefender = Instantiate(defender, transform.position, Quaternion.identity) as GameObject; 
    }
}
