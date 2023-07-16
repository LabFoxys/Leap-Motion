using UnityEngine;
using UnityEngine.UI;

namespace CubeSat.Scripts{

    public class TextoInformativo : MonoBehaviour{
        public Text text;

        public void setTexto( string texto ){
            text.text = texto;
        }
    }

}