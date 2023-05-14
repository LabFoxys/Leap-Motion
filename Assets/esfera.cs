using System;
using System.Collections;
using System.Collections.Generic;
using Leap.Unity.Interaction;
using UnityEngine;

public class esfera : MonoBehaviour{

    public InteractionBehaviour controlador;

    private void Update(){
    }

    private void OnCollisionEnter( Collision other ){
        if( controlador.isGrasped ){
            Debug.Log( "Le pegaste a algo" );
        }
        else{
            Debug.Log( "colision" );
        }
    }
}