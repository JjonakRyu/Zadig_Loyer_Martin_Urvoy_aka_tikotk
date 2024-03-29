using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour

{
    public float speed;
    Vector3 targetPos;

    public GameObject way;
    public Transform[] wayPoints;
    int pointIndex;
    int pointCount;
    int direction = 1;
    public float wait;
    int speedMultiplier = 1;

    private void Awake()
    {
        wayPoints = new Transform[way.transform.childCount];
        for (int i = 0; i < way.gameObject.transform.childCount; i++)
        {
            wayPoints[i] = way.transform.GetChild(i).gameObject.transform;
        }
    }

    private void Start()
    {
        pointCount = wayPoints.Length;
        pointIndex = 1;
        targetPos = wayPoints[pointIndex].transform.position;
    }

    private void Update()
    {
        var step = speedMultiplier * speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, step);

        if (transform.position == targetPos)
        {
            NextPoint();
        }
    }

    void NextPoint()
    {
        if (pointIndex == pointCount - 1)
        {
            direction = -1;
        }

        if (pointIndex == 0)
        {
            direction = 1;
        }

        pointIndex += direction;
        targetPos = wayPoints[pointIndex].transform.position;
        StartCoroutine(WaitNextPoint());
    }

    IEnumerator WaitNextPoint()
    {
        speedMultiplier = 0;
        yield return new WaitForSeconds(wait);
        speedMultiplier = 1;
    }
}
