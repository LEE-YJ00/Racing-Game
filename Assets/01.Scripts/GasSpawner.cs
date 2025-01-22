using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasSpawner : MonoBehaviour
{
    public GameObject GasPrefab;
    public Transform SpawnPoint;
    public List<Vector3> points = new List<Vector3>();

    public void SpawnGas()
    {
        StartCoroutine(ReSpawnGas());
    }
    public IEnumerator ReSpawnGas()
    {
        yield return new WaitForSeconds(1f);
        
        Instantiate(GasPrefab,SpawnPoint.position,Quaternion.identity,SpawnPoint);
    }
}
