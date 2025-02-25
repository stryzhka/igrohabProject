using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _Gravity;
    [SerializeField] private float _PlayerVelocity;

    [SerializeField] private float _MovementSpeed;

    [SerializeField] private float _JumpThrust;

    [SerializeField] private Rigidbody2D _Rigidbody;
    private float position = 0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("dfsf");
            _Rigidbody.AddForce(transform.up * _JumpThrust, ForceMode2D.Impulse);
        }
    }
}
