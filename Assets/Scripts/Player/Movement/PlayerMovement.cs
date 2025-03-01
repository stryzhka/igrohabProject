using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private MovementInput MovementInput;
    [SerializeField] private float _MovementSpeed;

    [SerializeField] private float _JumpThrust;

    [SerializeField] private Rigidbody2D _Rigidbody;

    [SerializeField] private Transform _PlayerCollider;

    [SerializeField] private LayerMask _Ground;

    private float _lastY;
    private float _moveX;
    public bool _onGround;

    public static event Action<Item> ItemCollisionInvoked;

    void OnEnable()
    {
        MovementInput.JumpInvoked += DoJump;
    }

    void OnDisable()
    {
        MovementInput.JumpInvoked -= DoJump;
    }

    
    void Update()
    {
        _PlayerCollider.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.8f);
        _onGround = Physics2D.OverlapCircle(_PlayerCollider.transform.position, 0.5f, _Ground);
        Move();
        
    }

    void Move()
    {
        if (_onGround)
        {
            _moveX = MovementInput.GetMoveX();
            if (_moveX != 0)
            {
                var impulse = (-_moveX * _MovementSpeed * Mathf.Deg2Rad ) * _Rigidbody.inertia; 
                _Rigidbody.AddTorque(impulse, ForceMode2D.Impulse);
            }
        }
    }

    public void DoJump()
    {
        if (_onGround)
        {
            Debug.Log("dfsf");
            _Rigidbody.AddForce(new Vector2(0, 1) * _JumpThrust, ForceMode2D.Impulse);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            ItemCollisionInvoked?.Invoke(collision.gameObject.GetComponent<Item>());
        }
    }


}
