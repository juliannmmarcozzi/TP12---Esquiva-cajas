using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Posiciones permitidas
    float izquierda = -2f;
    float centro = 0f;
    float derecha = 2f;

    void Update()
    {
        // IZQUIERDA
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x > izquierda)
            {
                transform.position += new Vector3(-2f, 0, 0);
            }
        }

        // DERECHA
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x < derecha)
            {
                transform.position += new Vector3(2f, 0, 0);
            }
        }
    }
}