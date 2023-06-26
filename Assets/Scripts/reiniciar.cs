using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reiniciar : MonoBehaviour{
    public void restart(){
        //Scene 
        SceneManager.LoadScene( "LeapEscena" );
    }
}