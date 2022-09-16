using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    [SerializeField] Vector3 rotateEulers = new Vector3(1f,1f,1f);

    float totalAngleChange;
    Quaternion startingAngle;

    // Start is called before the first frame update
    void Start()
    {
        totalAngleChange = 90f;
        startingAngle = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        float angleTraveled = GetDistanceRotated();

        if (angleTraveled > totalAngleChange)
        {
            FlipMoveDirection();
        }

        gameObject.transform.Rotate(rotateEulers * rotateSpeed);
    }

    void FlipMoveDirection()
    {
        rotateEulers = -rotateEulers;
    }

    float GetDistanceRotated()
    {
        return Quaternion.Angle(startingAngle,transform.rotation);
    }
}
