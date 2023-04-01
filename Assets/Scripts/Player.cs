using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public bool morreu;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput);

        movementDirection.Normalize();

        transform.position += movementDirection * speed * Time.deltaTime;
    }

   void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Inimigo"))
        {
            gameObject.SetActive(false);
            morreu = true;
        }
    }
}