using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activateMidUI : MonoBehaviour
{
    [SerializeField] Image theUI;
    // Start is called before the first frame update
    void Start()
    {
        theUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnableThisUI()
    {
        Debug.Log("EnableThisUI called");
        theUI.gameObject.SetActive(true);
    }
    public void DisableThisUI()
    {
        theUI.gameObject.SetActive(false);
    }
}
