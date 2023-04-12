using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    private Car _car;

    [SerializeField] private Vector3 ofset;

    private void Start()
    {
        _car = FindFirstObjectByType<Car>();
    }

    private void LateUpdate()
    {
        transform.position = _car.transform.position + ofset;
    }
}
