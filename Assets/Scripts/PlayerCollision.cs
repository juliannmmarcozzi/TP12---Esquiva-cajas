using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Caja"))
        {
            CajaMovement movement = col.gameObject.GetComponent<CajaMovement>();

            movement.StopMovement();

            GameManager.gameOver = true;

            Destroy(gameObject);
        }
    }
}