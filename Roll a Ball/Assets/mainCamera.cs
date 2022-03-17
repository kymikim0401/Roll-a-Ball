using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCamera : MonoBehaviour
{
    Transform PlayerTransform;
    Vector3 Offset;
    void Awake()
    {
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - PlayerTransform.position;
    }


    void LateUpdate()
    {
        transform.position = PlayerTransform.position + Offset;
    }
}
