using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelSkull : MonoBehaviour
{
    [SerializeField] GameObject[] labels;

    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject label in labels)
        {
            label.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        foreach (GameObject label in labels)
        {
            label.SetActive(false);
        }
    }
}
