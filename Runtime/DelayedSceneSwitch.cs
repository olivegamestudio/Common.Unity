using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Switches the scene after a specified delay.
/// </summary>
public class DelayedSceneSwitch : MonoBehaviour
{
    private float _time;

    /// <summary>
    /// Gets or sets the name of the scene to switch to.
    /// </summary>
    public string SceneName;

    /// <summary>
    /// Gets or sets the wait time before switching the scene.
    /// </summary>
    public float WaitTime;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        if (_time > WaitTime)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
