using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedToCamera : MonoBehaviour
{
    Vector3 _offset;

    public Camera Camera;

    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(
            Camera.transform.position.x + _offset.x,
            Camera.transform.position.y + _offset.y,
            transform.position.z);
    }
}
