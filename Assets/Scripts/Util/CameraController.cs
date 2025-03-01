using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _camera;
    [SerializeField] private float _rotatingSpeed;
    public bool _isRotating = false;
    public float rotate;

    void Start()
    {
        
    }

    void Update()
    {
        float lerp = 1 - Mathf.Exp(-Time.deltaTime * _rotatingSpeed);
        if (_isRotating)
            rotate = Mathf.Lerp(_camera.rotation.z, 360f, lerp);
        else
            rotate = Mathf.Lerp(_camera.rotation.z, 0f, lerp);
        _camera.rotation = Quaternion.Euler(0, 0, rotate);
    }

    public IEnumerator CameraTilt()
    {
        
        _isRotating = true;
        yield return new WaitForSeconds(0.1f);
        _isRotating = false;
        
    }
}
