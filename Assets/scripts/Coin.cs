using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1; 
    private Wallet wallet; 

    private void Start()
    {
        
        wallet = FindObjectOfType<Wallet>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            wallet.AddCoins(value); 
            Destroy(gameObject); 
        }
    }
}