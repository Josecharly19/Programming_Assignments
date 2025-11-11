using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Camera newCamera; //the cam that switches

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CameraManager camManager = FindFirstObjectByType<CameraManager>();
            camManager.SetActiveCamera(newCamera);
        }
    }
    
}
