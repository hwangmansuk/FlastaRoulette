using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerController : MonoBehaviour
{
    public void MoveToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void MoveToScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
