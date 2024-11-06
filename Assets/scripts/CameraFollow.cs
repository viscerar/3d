using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; 
    public Vector3 offset; 
    public float mouseSensitivity = 2.0f; 

    private float yaw; 
    private float pitch; 

    void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, -30f, 30f); 

        
        transform.eulerAngles = new Vector3(pitch, yaw, 0);

        
        transform.position = player.position + offset;
    }
}