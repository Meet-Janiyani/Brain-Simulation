using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkull : MonoBehaviour
{
    [SerializeField] float speed = 20f;

    void Update()
    {
        transform.Rotate(0f,speed*Time.deltaTime,0f);
    }
}
