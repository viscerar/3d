using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject panel; 
    private bool isPlayerOnButton = false;

    void Start()
    {
       
        panel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            isPlayerOnButton = true;
            panel.SetActive(true); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            isPlayerOnButton = false;
            panel.SetActive(false); 
        }
    }
}