using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOrbit : MonoBehaviour
{

    public float Gravity;

    public bool FixedDirection;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<GravityControl>())
        {
            //if this object has a gravity script, set this as the planet
            other.GetComponent<GravityControl>().Gravity = this.GetComponent<GravityOrbit>();
        }
    }
}
