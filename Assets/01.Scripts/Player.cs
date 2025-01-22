using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Player : MonoBehaviour
{
    [SerializeField] private float Energy = 100 ;
    [SerializeField] private float decreaseEnergy;
    [SerializeField] private TextMeshProUGUI playerEnergyText;
    
    void Update()
    {
        Move();
        DecreaseEnergy();
        ShowPlayerEnergy();
    }

    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if(transform.position.x > -1.5)
            transform.position += Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if(transform.position.x < 2.5)
            transform.position += Vector3.right;
        }
    }

    private void DecreaseEnergy()
    {
        Energy -= decreaseEnergy * Time.deltaTime;
    }

    private void ShowPlayerEnergy()
    {
        playerEnergyText.text = Energy.ToString("F0");
    }
}
