using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed;

    bool stopMovement = false;

    void Update()
    {
        if(stopMovement == false)
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
    }

    public void IncreaseSpeed()
    {
        speed += 1f;
    }

    public void StopMovement()
    {
        stopMovement = true;

        GetComponent<Rigidbody>().isKinematic = true;
    }
}