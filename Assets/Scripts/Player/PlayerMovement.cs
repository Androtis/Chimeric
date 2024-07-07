using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// sets up player movement
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerRB2D; //the players rigid body
    [SerializeField] private float movementSpeed; // the players movement scale

    //sets the players movements
    public void OnWalk(InputValue moveDirection){
        Vector2 moveValue = moveDirection.Get<Vector2>() * movementSpeed;
        //Vector3 normalMoveValue = new Vector3(moveValue.x, moveValue.y, 1f);
        Debug.Log(moveValue);
        playerRB2D.velocity = moveValue;
        
    }

    //the mouse gets pressed for shooting
    public void OnShoot(InputValue shootPress){

    }

    public void OnPause(){
        var pause = FindObjectOfType<PauseMenu>();
        if (pause.isActiveAndEnabled){
            pause.IsPause(true);
        } else {
            pause.IsPause(false);
        }
    }
}
