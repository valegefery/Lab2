using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 2.0f;
    private bool canMove = true;
    
    void Update()
    {
        if (canMove)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        // Проверяем имя объекта
        if (collision.gameObject.name == "Stena")
        {
            canMove = false;
            Debug.Log("Столкновение со стеной (Stena)!");
            
        }
    }
}