using System;
using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance {get; private set;}

    private float _moveSpeed = 6f;
    private float _minMovingSpeed = 0.1f;
    private bool _isRunning = false;

    private Rigidbody2D _rb;

    private void Awake()
    {
        Instance = this;
        _rb = GetComponent<Rigidbody2D>();
    }



    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement(){
        Vector2 _inputVector = GameInput.Instanse.GetMovementVector();
        
        _rb.MovePosition(_rb.position + _inputVector * (_moveSpeed * Time.fixedDeltaTime));

        if(Math.Abs(_inputVector.x) > _minMovingSpeed || Math.Abs(_inputVector.y) > _minMovingSpeed){
            _isRunning = true;
        } else{
            _isRunning = false;
        }
    }

    public bool IsRunning(){
        return _isRunning;
    }

    public Vector3 GetPlayerPosition(){
        Vector3 _playerPosition = Camera.main.WorldToScreenPoint(transform.position);
        return _playerPosition;
    }
}
