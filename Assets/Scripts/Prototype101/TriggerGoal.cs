using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGoal : MonoBehaviour
{
    public GameObject Roboter;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " triggered into " + gameObject.name);

        // when roboter collides with goal
        if(other.name == Roboter.name)
        {
            Debug.Log("Victory");
        }

    }
}