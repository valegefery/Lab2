using UnityEngine;

public class ForceWithRotation : MonoBehaviour
{
    public float forwardPower = 40f;
    public float rotationPower = 3f; 
    
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        
        // Движение вперед
        rb.AddForce(Vector3.forward * forwardPower);
        
        // Вращение вокруг оси Y (как юла)
        rb.AddTorque(Vector3.up * rotationPower * rotationPower);
        
        Debug.Log("Применена сила и вращение!");
    }
    
}