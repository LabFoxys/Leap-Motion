using System;
using UnityEngine;

namespace CubeSat.Scripts{

    public class Electronica : MonoBehaviour{
        public GameObject SistemaDeControl;
        public GameObject SistemaDeVuelo;
        public GameObject CargaUtil;

        public bool terminado = true;

        private void Start(){
            //Desactivate all the children
            for( int i = 0; i < transform.childCount; i++ ){
                transform.GetChild( i ).gameObject.SetActive( false );
            }
        }

        private void Update(){
            terminado = true;
            for( int i = 0; i < transform.childCount; i++ ){
                if( transform.GetChild( i ).gameObject.activeSelf ){
                    continue;
                }

                terminado = false;
                break;
            }

            if( terminado ){
                transform.GetComponent< BoxCollider >().isTrigger = false;
                transform.GetComponent<Rigidbody>().isKinematic = false;
            }
        }

        private void OnTriggerEnter( Collider other ){
            if( other.gameObject.GetComponent< Pieza >().id.Contains( "E" ) ){
                switch( int.Parse( other.gameObject.GetComponent< Pieza >().id[1].ToString() ) ){
                    case 1:
                        SistemaDeControl.SetActive( true );
                        Destroy( other.gameObject );
                        break;

                    case 2:
                        if( SistemaDeControl.activeSelf ){
                            SistemaDeVuelo.SetActive( true );
                            Destroy( other.gameObject );
                        }

                        break;

                    case 3:
                        if( SistemaDeVuelo.activeSelf ){
                            CargaUtil.SetActive( true );
                            Destroy( other.gameObject );
                        }

                        break;
                    default: break;
                }
            }
        }
    }

}