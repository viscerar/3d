using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что с зоной смерти взаимодействует игрок
        if (other.CompareTag("Player"))
        {
            // Запускаем корутину для перезагрузки сцены
            StartCoroutine(ReloadSceneWithDelay(2f)); // 2 секунды задержки
        }
    }

    private System.Collections.IEnumerator ReloadSceneWithDelay(float delay)
    {
        // Ждем заданное время
        yield return new WaitForSeconds(delay);

        // Перезагружаем текущую сцену
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}