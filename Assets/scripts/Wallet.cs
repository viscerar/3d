using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    public int balance = 0; 
    public Text balanceText; 

    private void Start()
    {
        
        balanceText.gameObject.SetActive(false);
    }

    public void AddCoins(int amount)
    {
        balance += amount; 
        UpdateBalanceText(); 
    }

    public void ShowBalance()
    {
        balanceText.gameObject.SetActive(true); 
        UpdateBalanceText();
    }

    private void UpdateBalanceText()
    {
        balanceText.text = "Balance: " + balance; 
    }
}