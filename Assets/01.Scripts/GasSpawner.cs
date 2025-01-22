using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GasSpawner : MonoBehaviour
{
    public List<GameObject> gases = new List<GameObject>();
    public Transform[] spawnPoints;
    private int randArray;
    private int currentIndex;
    private GameObject gas;

    private void Start()
    {
        randArray = Random.Range(0, 4); // gas의 종류 랜덤
        gas = gases[randArray];
        gas.SetActive(true);
    }

    private void Update()
    {
        if (!gas.activeSelf)
        {
            
            randArray = 0;
            randArray = Random.Range(0, 4);
            gas = gases[randArray];
            StartCoroutine(WaitRandomGas());
            
        }

        
    }

    // 일단 시작은 false고 시작은 랜덤 하나 켜짐 그게 꺼지면 다른 나머지 하나 켜짐. 이런 식으로 
    // 랜덤으로 하나 선택해서 활성화해야함..
    private IEnumerator WaitRandomGas()
    {
        yield return new WaitForSeconds(3f);
        gas.SetActive(true);
    }
}