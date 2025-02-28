using System;
using UnityEngine;
using UnityEngine.Events;

public class MovementInput : MonoBehaviour
{
    private float _moveX;
    private bool _touchButtonDown = false;

    [SerializeField] public PlayerMovement PlayerMovement;

    public static event Action JumpInvoked;
    
    void Start()
    {
        
    }

    void Update()
    {
        DoInput();
    }

    private void DoInput()
    {
        if (!_touchButtonDown)
        {
            _moveX = Input.GetAxis("Horizontal");
        }

        if (Input.GetButtonDown("Jump"))
        {
            JumpInvoked?.Invoke();
        }
    }

    public void DoJump()
    {
        
    }
    public float GetMoveX()
    {
        return _moveX;
    }

    public void TouchMoveLeft()
    {
        _touchButtonDown = true;
        _moveX = -1;
        Debug.Log("down");
        Debug.Log(_moveX);
    }

    public void TouchMoveRight()
    {
        _touchButtonDown = true;
        _moveX = 1;
        Debug.Log("right");
        Debug.Log(_moveX);
    }

    public void ResetMove()
    {
        _touchButtonDown = false;
        _moveX = 0;
        Debug.Log("up");
    }
}
