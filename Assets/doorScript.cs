using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public Transform openLocation;
    public float speed = 1.0f;
    private Vector3 closeVector;
    private Vector3 openVector;
    private Vector3 lastStart;

    private Vector3 currentGoal;

    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        closeVector = transform.position;
        openVector = openLocation.position;
        startTime = Time.time;
        currentGoal = closeVector;
        lastStart = closeVector;
    }

    // Update is called once per frame
    void Update()
    {
        float fractionOfJourney = (Time.time - startTime) * speed / Vector3.Distance(openVector,closeVector);
        transform.position = Vector3.Lerp(lastStart, currentGoal, fractionOfJourney);
    }

    public void open()
    {
        currentGoal = openVector;
        lastStart = transform.position;
        startTime = Time.time;
    }
    public void close()
    {
        currentGoal = closeVector;
        lastStart = transform.position;
        startTime = Time.time;
    }
}
