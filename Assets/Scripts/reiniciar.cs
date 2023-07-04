using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reiniciar : MonoBehaviour{
    public void restartMotor(){
        //Scene 
        SceneManager.LoadScene( "MotorEnsamble" );
    }
    
    public void restartCubeSat(){
        //Scene 
        SceneManager.LoadScene( "CubeSatEnsamble" );
    }
}