using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadExperience : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // take in scene name and load it
    public void LoadBaseScene(string baseName)
    {
        // unload the menu scene and load the base scene for the specified experience
        // this base scene should have a scene manager to handle additive scene loading
        SceneManager.LoadScene(baseName, LoadSceneMode.Single);
    }
}
