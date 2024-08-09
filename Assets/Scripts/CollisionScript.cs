using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    [SerializeField] Transform transformPoint;
    
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = transformPoint.position;
        other.transform.rotation = transformPoint.rotation;
        other.GetComponent<RotateSkull>().enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<RotateSkull>().enabled = false;
    }
}
