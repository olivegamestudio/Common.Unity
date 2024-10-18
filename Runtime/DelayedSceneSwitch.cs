using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayedSceneSwitch : MonoBehaviour
{
    float _time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        if (_time > 3.0f)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
