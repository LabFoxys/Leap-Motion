using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class HandsSelector : MonoBehaviour{
    public GameObject[] Manos;

    public int mano_actual = 0;
    public int mano_previa = 0;

    void Start(){
        for( int i = 0; i < Manos.Length; i++ ){
            Manos[i].SetActive( false );
        }

        Manos[mano_actual].SetActive( true );
    }

    private void Update(){
        //tecla f para ir a la mano previa
        if( Input.GetKeyDown( KeyCode.F ) ){
            mano_previa = mano_actual;
            mano_actual--;
            if( mano_actual < 0 ){
                mano_actual = Manos.Length - 1;
            }

            Manos[mano_previa].SetActive( false );
            Manos[mano_actual].SetActive( true );
        }

        //tecla J para ir a la siguiente mano
        if( Input.GetKeyDown( KeyCode.J ) ){
            mano_previa = mano_actual;
            mano_actual++;
            if( mano_actual > Manos.Length - 1 ){
                mano_actual = 0;
            }

            Manos[mano_previa].SetActive( false );
            Manos[mano_actual].SetActive( true );
        }
    }

}