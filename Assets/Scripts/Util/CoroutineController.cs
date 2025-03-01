using UnityEngine;

public class CoroutineController : MonoBehaviour
{
    [SerializeField] private CameraController CameraController;
    public void CameraTilt()
    {
        StartCoroutine(CameraController.CameraTilt());
    }   
}
