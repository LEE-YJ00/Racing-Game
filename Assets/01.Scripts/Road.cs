using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private float moveRoadSpeed;
    public Transform initPos;
    
    void Update()
    {
        transform.position -= new Vector3(0, 0, moveRoadSpeed) * Time.deltaTime;

        if (transform.position.z < -20)
        {
            transform.position = initPos.position;
        }
    }
}
