using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    public float Start;

    public float End;

    public float Duration;

    float _currentTime;

    void Update()
    {
        gameObject.GetComponent<Camera>().orthographicSize = Mathf.Lerp(Start, End, _currentTime / Duration);
        _currentTime += Time.deltaTime;
        if(_currentTime > Duration)
        {
            _currentTime = End;
            gameObject.GetComponent<Camera>().orthographicSize = Mathf.Lerp(Start, End, _currentTime / Duration);
            enabled = false;
        }
    }
}
