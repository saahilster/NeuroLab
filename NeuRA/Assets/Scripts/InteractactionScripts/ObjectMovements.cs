using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectMovements : MonoBehaviour
{
    //reference
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject model;
    private bool canSpawn = true;



    public void objectSpawnFunction()
    {
        if (canSpawn)
        {
            Instantiate(model, spawnPoint.position, spawnPoint.rotation);
            canSpawn = false;
        }
    }


}
