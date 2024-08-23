using System.Collections;
using UnityEngine;

public class BodyBehaviors : MonoBehaviour
{
    [SerializeField] GameObject startPoint;
    [SerializeField] GameObject targetPoint;
    [SerializeField] Canvas canvas;
    float speed = 3f;
    bool isFinished;
    bool isMoving;

    enum MovementDirection { None, Push, Pull }
    MovementDirection currentDirection = MovementDirection.None;

    IEnumerator finishCooldown()
    {
        yield return new WaitForSeconds(0.5f);
        isFinished = false;
        isMoving = false;
        currentDirection = MovementDirection.None;
    }

    void Start()
    {
        gameObject.transform.position = startPoint.transform.position;
        isFinished = false;
        isMoving = false;
        canvas.gameObject.SetActive(true);
    }

    void Update()
    {
        if (isMoving && !isFinished)
        {
            MoveBody();
        }
    }

    public void TogglePushBody()
    {
        currentDirection = MovementDirection.Push;
        isMoving = true;
        canvas.gameObject.SetActive(false);
    }

    public void TogglePullBody()
    {
        currentDirection = MovementDirection.Pull;
        isMoving = true;
        canvas.gameObject.SetActive(true);

    }

    void MoveBody()
    {
        Vector3 targetPosition = currentDirection == MovementDirection.Push ? targetPoint.transform.position : startPoint.transform.position;
        gameObject.transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            isFinished = true;
            isMoving = false;
            StartCoroutine(finishCooldown());
        }
    }
}
