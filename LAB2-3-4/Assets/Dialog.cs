using UnityEngine; 
using System.Collections; 
public class Dialog : MonoBehaviour { 

// Теперь метод принимает объект класса Collision, с которым происходит столкновение 
void OnCollisionEnter(Collision myCollision) { 
// определение столкновения с двумя разноименными объектами 
if (myCollision.gameObject.name == "Zemlya") {   
// Обращаемся к имени объекта, с которым столкнулись   
Debug.Log("Stolknulsya s Zemlei"); 
} 
else if (myCollision.gameObject.name == "Stena") { 
Debug.Log("Stolknulsya sо Stenoi "); 
} 
} 
} 