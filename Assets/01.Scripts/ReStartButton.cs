using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStartButton : MonoBehaviour
{
    public void OnButtonRestart()
    {
        SceneManager.LoadScene(0);
    }
}
