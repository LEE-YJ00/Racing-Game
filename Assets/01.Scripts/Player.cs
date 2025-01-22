using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    public float Energy = 100; 
    [SerializeField] private float decreaseEnergy;
    [SerializeField] private TextMeshProUGUI playerEnergyText;
    [SerializeField] private GameObject panel;

    void Start()
    {
        Energy = 100;
    }
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
            if (transform.position.x > -1.5)
                transform.position += Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x < 2.5)
                transform.position += Vector3.right;
        }
    }

    private void DecreaseEnergy()
    {
        Energy -= decreaseEnergy * Time.deltaTime;
        GameOver();
    }
    
    private void GameOver()
    {
        if (Energy < 0)
        {
            Energy = 0;
            Destroy(gameObject);
            panel.SetActive(true);
        }
    }

    private void ShowPlayerEnergy()
    {
        playerEnergyText.text = Energy.ToString("F0");
    }
}