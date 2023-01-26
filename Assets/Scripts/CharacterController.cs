using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D r2D;
    private Animator _animator;
    private Vector3 charPos;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private GameObject _camera;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        r2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        charPos = transform.position;
    }

    private void FixedUpdate()
    { 
        //r2D.velocity = new Vector2(speed, 0f);
        _camera.transform.position = new Vector3(charPos.x, charPos.y, charPos.z - 1.0f);
    }

    void Update()
    {

        charPos = new Vector3(charPos.x + (Input.GetAxis("Horizontal") * speed * Time.deltaTime), charPos.y);
        transform.position = charPos;
        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            _animator.SetFloat("Speed",0.0f);
        }
        else
        {
            _animator.SetFloat("Speed",speed);
        }

        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            _spriteRenderer.flipX = false;
        } else if (Input.GetAxis("Horizontal")<-0.01f)
        {
            _spriteRenderer.flipX = true;
        }




    }
    void LateUpdate()
    {
        //_camera.transform.position = new Vector3(charPos.x, charPos.y, charPos.z - 1.0f);
    }
}
