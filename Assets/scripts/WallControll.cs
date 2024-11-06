using UnityEngine;

public class WallControll : MonoBehaviour
{
    public GameObject wall;

    void Start()
    {

        wall.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            wall.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            wall.SetActive(true);
        }
    }
}