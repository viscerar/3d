using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // ���������, ��� � ����� ������ ��������������� �����
        if (other.CompareTag("Player"))
        {
            // ��������� �������� ��� ������������ �����
            StartCoroutine(ReloadSceneWithDelay(2f)); // 2 ������� ��������
        }
    }

    private System.Collections.IEnumerator ReloadSceneWithDelay(float delay)
    {
        // ���� �������� �����
        yield return new WaitForSeconds(delay);

        // ������������� ������� �����
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}