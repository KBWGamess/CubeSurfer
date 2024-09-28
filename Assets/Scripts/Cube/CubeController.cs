using UnityEngine;

public class CubeController : MonoBehaviour
{
    public PlayerCubeStack playerCubeStack;

    private Vector3 direction = Vector3.back;
    private RaycastHit hit;
    private bool isStack = false;

    void Start()
    {
        playerCubeStack = GameObject.FindObjectOfType<PlayerCubeStack>();
    }

    void FixedUpdate()
    {
        SetCubeRaycast();
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void SetCubeRaycast()
    {
        if (Physics.Raycast(transform.position, direction, out hit, 1f))
        {
            if (!isStack)
            {
                isStack = true;
                playerCubeStack.IncreaseBlockStack(gameObject);
                SetDirection();
            }

            if (hit.transform.name == "Obstacle")
            {
                playerCubeStack.DecreaseBlockStack(gameObject);
            }
        }
    }

    private void SetDirection()
    {
        direction = Vector3.forward;
    }
}
