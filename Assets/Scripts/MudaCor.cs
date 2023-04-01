using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudaCor : MonoBehaviour
{
    public Material mat;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material = mat;
    }

}
