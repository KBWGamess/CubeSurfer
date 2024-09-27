using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerConroller conroller;

    public float forwardMovementSpeed;
    public float horizontalMovementSpeed;
    public float horizontalLimitValue;

    private float newPositionX;

    void Start()
    {
        
    }


    void FixedUpdate()
    {
        SetPlayerForwardMovement();
        SetPlayerHorizontalMovement();
    }

    private void SetPlayerForwardMovement()
    {
        transform.Translate(Vector3.down * forwardMovementSpeed * Time.fixedDeltaTime);
    }

    private void SetPlayerHorizontalMovement()
    {
        newPositionX = transform.position.x + conroller.HorizontalValue * horizontalMovementSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizontalLimitValue, horizontalLimitValue);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
