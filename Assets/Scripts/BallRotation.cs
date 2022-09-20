using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] GameObject CenterCircle;
    bool direction = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = 150 * Time.deltaTime;
        if (direction)
            transform.RotateAround(CenterCircle.transform.position, Vector3.forward, speed);
        else
            transform.RotateAround(CenterCircle.transform.position, Vector3.back, speed);
    }

    public void ChangeDirection()
    {
        direction = !direction;
    }
}
