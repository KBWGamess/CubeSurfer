using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    private float horizontalValue;

    public float HorizontalValue
    {
        get { return horizontalValue; }
    }

    void Start()
    {
        
    }


    void Update()
    {
        HandlePlayerHorizontalInput();
    }

    void HandlePlayerHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {
            horizontalValue = 0;
        }
    }
}
