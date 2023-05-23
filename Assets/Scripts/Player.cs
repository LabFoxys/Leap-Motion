using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

    public Vector2 speed_rotation = new Vector2( 1, 1 );
    public float   spped_move     = 1;
    public Camera  my_camera;
    public bool    isLocked = false;

    private float y_rotation = 0;

    public Rigidbody       my_rigidbody;
    public Transform       body;
    public CapsuleCollider collider;
    bool                   is_small = false;



    private void Update(){
        if( Input.GetKeyDown( KeyCode.M ) ){
            if( is_small ){
                collider.height = 2f;
                body.localScale = new Vector3( 0.2f, 2f, 0.2f );

                is_small = false;
            }
            else{
                collider.height = 0f;
                body.localScale = new Vector3( 0.2f, 0.2f, 0.2f );
                is_small        = true;
            }
        }

        if( Input.GetKeyDown( KeyCode.Space ) ){
            showOrHideCursor();
        }

        float multiplier = 1;
        if( Input.GetKey( KeyCode.LeftShift ) ){
            multiplier = 4;
        }

        my_rigidbody.velocity =
            transform.forward       * ( Input.GetAxis( "Vertical" )   * spped_move * multiplier ) +
            transform.right         * ( Input.GetAxis( "Horizontal" ) * spped_move * multiplier ) +
            my_rigidbody.velocity.y * Vector3.up;

        if( isLocked ){
            transform.Rotate( 0, Input.GetAxis( "Mouse X" ) * speed_rotation.x, 0 );
            y_rotation                   += Input.GetAxis( "Mouse Y" ) * speed_rotation.y;
            y_rotation                   =  Mathf.Clamp( y_rotation, -60, 60 );
            my_camera.transform.rotation =  Quaternion.Euler( -y_rotation, transform.rotation.eulerAngles.y, 0 );
        }
    }

    public void showOrHideCursor(){
        if( isLocked ){
            Cursor.lockState = CursorLockMode.None;
            //Cursor.visible   = true;
            isLocked = false;
        }
        else{
            Cursor.lockState = CursorLockMode.Locked;
            //Cursor.visible   = false;
            isLocked = true;
        }
    }
}