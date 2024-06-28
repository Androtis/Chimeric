using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class Pistol : MonoBehaviour
{
    //Variables
    private float ammo;
    private Bullet bullet;
    private Rigidbody2D rb2d;
    [SerializeField] SpriteRenderer sprite;
    

    //Setting Up Components
    private void Awake() {
        ammo = Mathf.Infinity;
        bullet = GetComponent<Bullet>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        CursorDistanceFromPlayer();
        Shoot();
    }

    //Fires a Bullet
    private void Shoot() {
        Bullet firedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        firedBullet.GetComponent<Rigidbody2D>().velocity = Vector2.left; //change to mouse
        ammo -= 1;
    }

    //Moves gun according to the Mouse
    private void CursorDistanceFromPlayer() {

    }

}
