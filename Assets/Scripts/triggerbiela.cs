using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerbiela : MonoBehaviour

{

    public bool colocada;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<bielaarmada>(out bielaarmada biela))
        {
            if (biela.armada && colocada == false) {
                colocada= true;
                Destroy(other.gameObject);
            }
        }
    }
}
