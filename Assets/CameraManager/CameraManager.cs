using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera activeCamera; //camera being used

    void Start()
    {
        SetActiveCamera(activeCamera);
    }

    public void SetActiveCamera(Camera newCam)
    {
        //disable other cameras
        Camera[] cameras = FindObjectsByType<Camera>(FindObjectsSortMode.None);
        foreach (Camera cam in cameras)
        {
            cam.gameObject.SetActive(false);
        }

        //enable new camera
        newCam.gameObject.SetActive(true);
        activeCamera = newCam;
    }
    
}
