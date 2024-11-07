using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public float swingAngle = 45f; 
    public float swingSpeed = 10f;   

    private float currentAngle;
    private bool movingRight = true;

    void Update()
    {
        
        if (movingRight)
        {
            currentAngle += swingSpeed * Time.deltaTime;
            if (currentAngle >= swingAngle)
            {
                movingRight = false;
            }
        }
        else
        {
            currentAngle -= swingSpeed * Time.deltaTime;
            if (currentAngle <= -swingAngle)
            {
                movingRight = true;
            }
        }

        
        transform.localRotation = Quaternion.Euler(0, 0, currentAngle);
    }
}