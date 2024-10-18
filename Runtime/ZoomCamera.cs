
using UnityEngine;

/// <summary>  
/// Controls the zooming of the camera over a specified duration.  
/// </summary>  
public class ZoomCamera : MonoBehaviour
{
    /// <summary>  
    /// Gets or sets the starting orthographic size of the camera.  
    /// </summary>  
    public float Start;

    /// <summary>  
    /// Gets or sets the ending orthographic size of the camera.  
    /// </summary>  
    public float End;

    /// <summary>  
    /// Gets or sets the duration over which the zoom occurs.  
    /// </summary>  
    public float Duration;

    private float _currentTime;

    /// <summary>  
    /// Updates the camera's orthographic size each frame to create a zoom effect.  
    /// </summary>  
    void Update()
    {
        gameObject.GetComponent<Camera>().orthographicSize = Mathf.Lerp(Start, End, _currentTime / Duration);
        _currentTime += Time.deltaTime;
        if (_currentTime > Duration)
        {
            _currentTime = End;
            gameObject.GetComponent<Camera>().orthographicSize = Mathf.Lerp(Start, End, _currentTime / Duration);
            enabled = false;
        }
    }
}
