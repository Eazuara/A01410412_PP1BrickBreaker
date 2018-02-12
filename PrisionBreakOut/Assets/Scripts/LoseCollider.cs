using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    //This method is triggered when the ball touches the LoseCollider game Object
    void OnTriggerEnter2D(Collider2D collider){
        //We need to instance a LevelManager object to call the LoadLevel method
        LevelManager levelManager = new LevelManager();
        levelManager.LoadLevel("Lose");
    }
}