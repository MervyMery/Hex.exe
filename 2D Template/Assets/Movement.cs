using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(Rigidbody))] 
public class Movement : MonoBehaviour
{
    public float movementSpeed;
    private Rigidbody2D rb;
    private Vector2 moveAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb= GetComponent <Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.linearVelocityX = moveAmount.x * movementSpeed;
    }

    public void HandleMovement(InputAction.CallbackContext ctx)
    {
       
        moveAmount = ctx.ReadValue<Vector2>();  
    }
}
