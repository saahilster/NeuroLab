using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Point3DScript : MonoBehaviour
{
    [SerializeField] UnityEvent colorChange;
    private Renderer sphereRenderer;
    // Start is called before the first frame update
    void Start()
    {
        sphereRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GameController")
        {
            Debug.Log("Hand Collided");
            colorChange.Invoke();
        }
    }

    //Testing Worked
    public void ChangeColor()
    {
        sphereRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }

    public void SpawnPOI()
    {

    }
}
