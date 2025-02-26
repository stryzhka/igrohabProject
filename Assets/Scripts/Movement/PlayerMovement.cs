using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _MovementSpeed;

    [SerializeField] private float _JumpThrust;

    [SerializeField] private Rigidbody2D _Rigidbody;

    [SerializeField] private Transform _PlayerCollider;

    [SerializeField] private LayerMask _Ground;

    private float _lastY;
    public bool _onGround;
    void Start()
    {

    }

    
    void Update()
    {
        _onGround = Physics2D.OverlapCircle(_PlayerCollider.transform.position, 1f, _Ground);
        Move();
    }

    void Move()
    {
        
        if (_onGround)
        {
            float xMove = Input.GetAxis("Horizontal");
            if (xMove != 0)
            {
                var impulse = (-xMove * _MovementSpeed * Mathf.Deg2Rad ) * _Rigidbody.inertia; 
                _Rigidbody.AddTorque(impulse, ForceMode2D.Impulse);
            }
            if (Input.GetButtonDown("Jump"))
            {
                Debug.Log("dfsf");
                _Rigidbody.AddForce(new Vector2(0, 1) * _JumpThrust, ForceMode2D.Impulse);
                
            }
        }
        
        
    }
}
