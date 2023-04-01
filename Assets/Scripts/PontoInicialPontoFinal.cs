using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontoInicialPontoFinal : MonoBehaviour
{
    // Vector3 goal = new Vector3(5,0,4)
    public float speed = 2.0f;
    public Transform goal;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = goal.position - this.transform.position;
        if (direction.magnitude > 0.2)
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
    }
}
