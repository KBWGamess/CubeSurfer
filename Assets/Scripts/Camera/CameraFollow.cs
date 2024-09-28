using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float lerpValue;

    private Vector3 offset;
    private Vector3 newPosition;


    void Start()
    {
        offset = transform.position - player.position;
    }


    void Update()
    {
        
    }

    private void LateUpdate()
    {
        SetCameraFollow();
    }

    private void SetCameraFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, player.position.y, player.position.z) + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
