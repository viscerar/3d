using UnityEngine;

public class FallThroughButton : MonoBehaviour
{
    public GameObject player; 
    public Vector3 fallPosition; 

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            other.transform.position = fallPosition;
        }
    }
}