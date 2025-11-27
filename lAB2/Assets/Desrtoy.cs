using UnityEngine;

public class Destroy : MonoBehaviour 
{
    void OnCollisionEnter(Collision myCollision) 
    { 
        // определение столкновения с объектом "Zemlya"
        if (myCollision.gameObject.name == "Zemlya") 
        {   
            Destroy(gameObject); 
        }
    } 
}