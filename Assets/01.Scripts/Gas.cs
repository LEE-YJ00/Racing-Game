using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{
    public int gasPoints = 20;
    [SerializeField] private Player player;
    [SerializeField] private Gas gas;
    public GasSpawner gasSpawner;
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LossEnergy();
            gasSpawner.SpawnGas();
            Destroy(this.gameObject);
            Debug.Log(player.Energy);
        }
    }
    
    private void LossEnergy()
    {
        player.Energy += gas.gasPoints;
    }
}
