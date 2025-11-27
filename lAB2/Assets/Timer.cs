using UnityEngine;

public class Timer : MonoBehaviour
{
    public float myTimer = 5.0f;
    private bool gameEnded = false;  // флаг для отслеживания окончания игры
    
    void Update()
    {
        if (!gameEnded)  // если игра еще не окончена
        {
            if (myTimer > 0)
            {
                myTimer -= Time.deltaTime;
            }
            else
            {
                Debug.Log("GAME OVER");
                gameEnded = true;  // устанавливаем флаг, что игра окончена
            }
        }
    }
}