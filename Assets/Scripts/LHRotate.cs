using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHRotate : MonoBehaviour
{
    [SerializeField] GameObject LHObject;
    [SerializeField] float speed = 0.3f;

    // Update is called once per frame
    void Update()
    {
        LHObject.transform.Rotate(0.0f, speed, 0.0f, Space.World);
    }
}
