using UnityEngine;

public class FixedRotationToCamera : MonoBehaviour
{
    public Camera Camera;

    void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(Camera.transform.rotation.eulerAngles);
    }
}
