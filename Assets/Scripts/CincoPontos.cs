using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CincoPontos : MonoBehaviour
{
    // declara um array de transform que representa os waypoints
    public Transform[] waypoints;
    // velocidade de movimento do objeto
    public float speed = 5.0f;
    // waypoint atual que o objeto está movendo em direção
    private int currentWaypoint = 0;

    // Update is called once per frame
    void Update()
    {
        // verifica se o índice do waypoint atual é menor do que o tamanho do array de waypoints
        if (currentWaypoint < waypoints.Length)
        {
            // move o bjeto em direção ao waypoint atual
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint].position, speed * Time.deltaTime);
            // verifica se o objeto atingiu o waypoint
            if (transform.position == waypoints[currentWaypoint].position)
            {
                // avança para o próximo waypoint
                currentWaypoint++;

            }
        }
    }
}
