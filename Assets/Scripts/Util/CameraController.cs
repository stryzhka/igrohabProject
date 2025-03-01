using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _PlayerFollow;
    [SerializeField] private float _DampTime = 5f;

    [SerializeField] private float _xOffset, _yOffset = 0;

    [SerializeField] private float _margin = 0.1f;
    [SerializeField] private Camera _camera;
    [SerializeField] private float _rotatingSpeed;
    public bool _isRotating = false;
    public bool _isFoving = false;
    public float rotate;

    public float fov;

    

    void Start()
    {
        
    }

    void Update()
    {
        float lerp = 1 - Mathf.Exp(-Time.deltaTime * _rotatingSpeed);
        if (_isRotating)
            rotate = Mathf.Lerp(_camera.transform.rotation.z, 360f, lerp);
        else
            rotate = Mathf.Lerp(_camera.transform.rotation.z, 0f, lerp);
        _camera.transform.rotation = Quaternion.Euler(0, 0, rotate);

        float fovLerp = 1 - Mathf.Exp(-Time.deltaTime * _rotatingSpeed);
        if (_isFoving)
                fov = Mathf.Lerp(_camera.orthographicSize, 10f, fovLerp);
        else   
            fov = Mathf.Lerp(_camera.orthographicSize, 5f, fovLerp); 
        _camera.orthographicSize = fov;

        float targetX = _PlayerFollow.position.x + _xOffset;
		float targetY = _PlayerFollow.position.y + _yOffset;
		if (Mathf.Abs(transform.position.x - targetX) > _margin)
			targetX = Mathf.Lerp(transform.position.x, targetX, _DampTime * Time.deltaTime);
		if (Mathf.Abs(transform.position.y - targetY) > _margin)
			targetY = Mathf.Lerp(transform.position.y, targetY, _DampTime * Time.deltaTime);
		transform.position = new Vector3(targetX, targetY, transform.position.z);

    }

    public IEnumerator CameraTilt()
    {
        
        _isRotating = true;
        yield return new WaitForSeconds(0.1f);
        _isRotating = false;
        
    }

    public IEnumerator CameraZoom()
    {
        if (!_isFoving)
        {
            _isFoving = true;
            yield return new WaitForSeconds(0.1f);
            _isFoving = false;
        }
        
        
    }

    public IEnumerator CameraZoomForTime(float time)
    {
        
        _isFoving = true;
        yield return new WaitForSeconds(time);
        _isFoving = false;
        
    }
}
