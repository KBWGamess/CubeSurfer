using System.Collections.Generic;
using UnityEngine;

public class PlayerCubeStack : MonoBehaviour
{

    public List<GameObject> blockList = new List<GameObject>();

    private GameObject lastBlockObject;

    void Start()
    {
        UpdateLastBlockObject();
    }

    void Update()
    {
        
    }

    public void IncreaseBlockStack(GameObject gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z); 
        gameObject.transform.position = new Vector3(lastBlockObject.transform.position.x, lastBlockObject.transform.position.y - 2f, lastBlockObject.transform.position.z);
        gameObject.transform.SetParent(transform);
        blockList.Add(gameObject);
        UpdateLastBlockObject();
    }

    public void DecreaseBlockStack(GameObject gameObject)
    {
        gameObject.transform.parent = null;
        blockList.Remove(gameObject);
        UpdateLastBlockObject();
    }

    private void UpdateLastBlockObject()
    {
        lastBlockObject = blockList[blockList.Count - 1];
    }
}
