using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    
    /// <summary>
    /// Load scene
    /// </summary>
    /// <param name="name">The name of the level to load</param>
    public void LoadLevel(string name){
        SceneManager.LoadScene(name);
    }

    /// <summary>
    /// Quit the game
    /// </summary>
    public void QuitRequest(){
        Application.Quit();
    }

    /// <summary>
    /// Go back to a specified location
    /// </summary>
    /// <param name="name">The name of the scene to go back to</param>
    public void Back(string name){
        SceneManager.LoadScene(name);
    }
}
