using UnityEngine;
using UnityEngine.Events;

public class ObjectOnSpawn : MonoBehaviour
{
    [SerializeField] GameObject startPosition;
    [SerializeField] GameObject endPosition;
    bool isFinished;
    private float speed = 1;

    //set up for mid UI
    //[SerializeField] UnityEvent enableMidUI;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = startPosition.transform.position;
        isFinished = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveObject(gameObject);
    }

    public void moveObject(GameObject obj)
    {
        if (!isFinished)
        {
            obj.transform.position = Vector3.MoveTowards(transform.position, endPosition.transform.position, speed * Time.deltaTime);
            if (obj.transform.position == endPosition.transform.position)
            {
                isFinished = true;
            }
        }
        else
        {
            speed = 0;
        }

    }
}
