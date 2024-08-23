using UnityEngine;
using UnityEngine.Events;

public class ObjectOnSpawn : MonoBehaviour
{
    public SubjectInfo objectData;
    bool isFinished;
    private float speed = 1;

    //set up for mid UI
    //[SerializeField] UnityEvent enableMidUI;

    // Start is called before the first frame update
    void Start()
    {
        isFinished = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
