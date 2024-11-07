using UnityEngine;
using UnityEngine.UI;

public class Portal : MonoBehaviour
{
    public Transform destination; 
    public GameObject panel; 
    private bool isPlayerInPortal = false;

    void Start()
    {
        
        panel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            other.transform.position = destination.position;
            panel.SetActive(true); 
            isPlayerInPortal = true;

            
            Wallet wallet = FindObjectOfType<Wallet>();
            if (wallet != null)
            {
                wallet.ShowBalance();
            }
        }
    }

    private void Update()
    {
        
        if (isPlayerInPortal && Input.anyKeyDown)
        {
            panel.SetActive(false); 
            isPlayerInPortal = false; 
        }
    }
}