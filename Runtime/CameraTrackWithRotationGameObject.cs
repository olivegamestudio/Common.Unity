using UnityEngine;

public class CameraTrackWithRotationGameObject : MonoBehaviour
{
    public GameObject GameObject;

    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        // Update the camera's position to match the target's position with an offset
        Quaternion z = Quaternion.Lerp(transform.rotation, GameObject.transform.rotation, 0.01f);
        transform.rotation = z;

        transform.position = new Vector3(GameObject.transform.position.x, GameObject.transform.position.y, transform.position.z);
    }
}
