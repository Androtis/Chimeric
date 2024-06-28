using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    SpriteRenderer bulletSprite;
    Animator bulletAni;
    [SerializeField] Collider2D bulletCL2d;
    Rigidbody2D bulletRB2d;

    private void Awake() {
        bulletSprite = GetComponent<SpriteRenderer>();
        bulletAni = GetComponent<Animator>();
        bulletRB2d = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
    }

}
