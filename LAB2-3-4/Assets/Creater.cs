using UnityEngine;

public class Creater : MonoBehaviour
{
    public GameObject thePrefab;  
   
void Start () { 
  GameObject instance = new GameObject(); 
  instance = Instantiate(thePrefab,transform.position,transform.rotation) as GameObject;  
}
}
