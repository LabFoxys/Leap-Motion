using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonesTrabajando : MonoBehaviour
{

    public GameObject[] Vielas = new GameObject[4];

    public triggerbiela[] triggers = new triggerbiela[4];

    public GameObject trabajando;

    // Update is called once per frame
    void Update()
    {
        bool activar = true;
        for(int i = 0; i < 4; i++)
        {
            Vielas[i].SetActive(triggers[i].colocada);
            activar = activar && triggers[i].colocada;
        }

        if (activar) {
            Instantiate(trabajando, transform.position, transform.rotation);
            Destroy(gameObject);
        }


        
    }
}
