using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //changes the scene
    public void changeScene(SceneAsset scene)
    {
        SceneManager.LoadScene(scene.name);
    }

    //quits the game
    public void quitGame()
    {
        Application.Quit();
    }
}
