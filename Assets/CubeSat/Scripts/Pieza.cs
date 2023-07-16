using UnityEngine;

namespace CubeSat.Scripts{

    public class Pieza : MonoBehaviour{
        public string id;

        public TextoInformativo textoInformativo;

        public void mostrarInfo(){
            if( id == "A1" ){ //Chasis
                textoInformativo.setTexto( "Bus o Chasis: Estructura metálica que transporta todos los subsistemas del CubeSat." );
            }
            else if( id == "A2" ){ //Antenas y rueda
                textoInformativo.setTexto( "Antenas: Permite la comunicación bidireccional entre el CubeSat y las estaciones terrestres." );
            }
            else if( id == "A3" || id == "A4" || id == "A5" || id == "A6" || id == "A7" ){ //Panel solar
                textoInformativo.setTexto( "Panel solar: Transforma la energía solar en energía eléctrica." );
            }
            else if( id == "E1" ){ //Sistema de control
                textoInformativo.setTexto(
                    "Subsistema de Potencia: Almacena la energia de los paneles solares en baterias que se activan en lugares oscuros, donde los paneles no pueden recargarlas."
                );
            }
            else if( id == "E2" ){ //Sistema de vuelo
                textoInformativo.setTexto( "Computadora de vuelo: Controla al satélite y almacena los datos" );
            }
            else if( id == "E3" ){ //Carga util
                textoInformativo.setTexto( "Carga útil: Es la instrumentación científica que captará y medirá las variables de interés." );
            }
        }

    }

}