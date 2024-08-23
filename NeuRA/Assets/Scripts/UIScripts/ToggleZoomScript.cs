using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleZoomScript : MonoBehaviour
{
    public bool willZoom;
    // Start is called before the first frame update
    void Start()
    {
        willZoom = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ToggleZoom()
    {
        willZoom = !willZoom;
    }
}
