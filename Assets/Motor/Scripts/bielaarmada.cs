using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bielaarmada : MonoBehaviour
{

    public bool armada;
    public GameObject piston;


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<piston>(out piston pisto))
        {
            if (armada == false)
            {
                armada = true;
                piston.SetActive(true);
                Destroy(other.gameObject);
            }
        }
    }
}
