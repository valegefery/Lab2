using UnityEngine;
using UnityEngine.InputSystem;

public class NewEmptyCSharpScript : MonoBehaviour
{
    private PlayerInput playerInput;
    private InputAction jumpAction;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        jumpAction = playerInput.actions["Jump"];
    }

    void Update()
    {
        if (jumpAction.triggered) 
        { 
            Debug.Log("We Have Hit the Space Bar"); 
        }  
    }
}