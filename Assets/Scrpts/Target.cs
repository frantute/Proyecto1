using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Transform targetTR;
    public float speed;

    void Update()
    {
        Vector3 currentEulerAngles = transform.eulerAngles;
        transform.LookAt(targetTR);
        transform.eulerAngles = new Vector3(currentEulerAngles.x, transform.eulerAngles.y, currentEulerAngles.z);
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetTR.position, step);
    }
}
