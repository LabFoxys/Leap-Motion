using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace CubeSat.Scripts{

    public class Armazon : MonoBehaviour{
        public GameObject Chasis;
        public GameObject AntenasRueda;

        public GameObject[] Paneles;

        public bool terminado = true;

        public GameObject CubeSat;

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
        }

        private void OnTriggerEnter( Collider other ){
            Pieza       pieza       = other.gameObject.GetComponent< Pieza >();
            Electronica electronica = other.gameObject.GetComponent< Electronica >();

            if( pieza != null && pieza.id.Contains( "A" ) ){
                int id = int.Parse( other.gameObject.GetComponent< Pieza >().id[1].ToString() );
                if( id == 1 ){
                    Chasis.SetActive( true );
                    Destroy( other.gameObject );
                }
                else if( id == 2 ){
                    if( Chasis.activeSelf ){
                        AntenasRueda.SetActive( true );
                        Destroy( other.gameObject );
                    }
                }
                else if( id >= 3 ){
                    if( AntenasRueda.activeSelf ){
                        Paneles[id - 3].SetActive( true );
                        Destroy( other.gameObject );
                    }
                }
            }

            else if( electronica != null && electronica.terminado && terminado ){
                Destroy( other.gameObject );
                gameObject.SetActive( false );
                CubeSat.transform.position = transform.position;
                CubeSat.SetActive( true );
            }
        }
    }

}