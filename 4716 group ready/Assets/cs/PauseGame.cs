using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject MenuCall;
    void Pause() 
    {
        MenuCall.SetActive(true);
        Time.timeScale = 0f;
    }

}
