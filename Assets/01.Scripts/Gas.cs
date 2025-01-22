using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gas : MonoBehaviour
{
    public int gasPoints = 20;
    Player player;
    private int gasMoveSpeed;
    private int gasMoveCount;
    public Transform gasInitPos;
    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        transform.position -= new Vector3(0, 0, gasMoveSpeed) * Time.deltaTime;
                                                                        
        if (transform.position.z < -20)                                         
        {
            transform.position = gasInitPos.position;                              
        }                                                                       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LossEnergy();
            this.gameObject.SetActive(false);
        }
    }
    
    private void LossEnergy()
    {
        if (player != null)
        {
            player.Energy += gasPoints;    
        }
        
    }
}
