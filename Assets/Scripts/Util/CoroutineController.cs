using UnityEngine;

public class CoroutineController : MonoBehaviour
{
    [SerializeField] private CameraController CameraController;
    public void CameraTilt()
    {
        StartCoroutine(CameraController.CameraTilt());
    }   

    public void CameraZoom()
    {
        StartCoroutine(CameraController.CameraZoom());
    }  

    public void CameraZoomForTime()
    {
        StartCoroutine(CameraController.CameraZoomForTime(5));
    }  
}
