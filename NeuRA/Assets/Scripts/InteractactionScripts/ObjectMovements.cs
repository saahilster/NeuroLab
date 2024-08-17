using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectMovements : MonoBehaviour
{
    public UnityEvent objectAttract;
    public UnityEvent objectRepel;
    public UnityEvent spawnObject;

    //move object
    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform endPoint;
    [SerializeField] GameObject model;

    private float speed = 0.75f;

    IEnumerator AttractDelay()
    {
        yield return new WaitForSeconds(0.5f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void objectSpawnFunction()
    {
        Instantiate(model, endPoint.position, endPoint.rotation);
        
    }
    public void objectRepelFunction()
    {

    }

}
